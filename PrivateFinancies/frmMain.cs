using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateFinancies
{
    public partial class frmMain : Form
    {
        public DataClasses1DataContext db;
        private enum MoveDirection { Up, Down };
        private enum AdditionCase { AccountSingle, AccountGroup, ItemSingle, ItemGroup };

        public frmMain()
        {
            InitializeComponent();  // Framework method

            db = new DataClasses1DataContext();
            InitTreeView(trvAccounts);
            InitTreeView(trvItems);
            InitCurrencies();
        }

        public void InitTreeView(TreeView trv)
        {
            trv.Nodes.Clear();
            if (trv == trvAccounts)
                FillAccountNode(trv.Nodes, null);
            else if (trv == trvItems)
                FillItemNode(trv.Nodes, null);
            trv.ExpandAll();
            trv.SelectedNode = trv.Nodes[0];
        }

        public void FillAccountNode(TreeNodeCollection parentNodes, int? parentAccountId)
        {
            Account[] accounts;
            if (parentAccountId.HasValue)
            {
                accounts = db.Account.Where(x => x.Parent == parentAccountId.Value)
                    .OrderBy(x => x.OrderNumber).ToArray();
            }
            else
            {
                accounts = db.Account.Where(x => x.Parent == null).ToArray();
            }
            foreach (Account account in accounts)
            {
                //TreeNode node = new TreeNode(
                //    String.Format("{0} ({1})", account.Name, account.Currency1.NameShort));
                TreeNode node = new TreeNode(account.Name);
                node.Tag = account;
                parentNodes.Add(node);
                if (account.IsFolder)
                {
                    node.ForeColor = Color.Green;  // TODO: later set image here.
                    FillAccountNode(node.Nodes, account.Id);
                }
                else
                {
                    // TODO: Here image for node shall be set.
                }
            }
        }

        public void FillItemNode(TreeNodeCollection parentNodes, int? parentItemId)
        {
            Item[] items;
            if (parentItemId.HasValue)
            {
                items = db.Item.Where(x => x.Parent == parentItemId.Value)
                    .OrderBy(x => x.OrderNumber).ToArray();
            }
            else
            {
                items = db.Item.Where(x => x.Parent == null).ToArray();
            }
            foreach (Item item in items)
            {
                TreeNode node = new TreeNode(item.Name);
                node.Tag = item;
                parentNodes.Add(node);
                if (item.IsFolder)
                {
                    node.ForeColor = Color.Green;  // TODO: later set image here.
                    FillItemNode(node.Nodes, item.Id);
                }
                else
                {
                    // TODO: Here image for node shall be set.
                }
            }
        }

        public void InitCurrencies()
        {
            // TODO: how to get all currencies without Where()
            IEnumerable<Currency> currencies = db.Currency.Where(x => true);
            foreach (Currency currency in currencies)
            {
                int index = dgvCurrencies.Rows.Add(currency.OrderNumber, currency.NameFull, currency.NameShort, currency.IsMain);
                dgvCurrencies.Rows[index].Tag = currency;
            }

        }

        private void btCreateAccountGroup_Click(object sender, EventArgs e)
        {
            CreateAccount(AdditionCase.AccountGroup);
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount(AdditionCase.AccountSingle);
        }

        private void CreateAccount(AdditionCase additionCase)
        {
            // Identifying a group where new account shall be created
            Account parentAccount = (Account)trvAccounts.SelectedNode.Tag;
            TreeNode parentNode = trvAccounts.SelectedNode;
            if (!parentAccount.IsFolder)
            {
                parentAccount = db.Account.Single(x => x.Id == parentAccount.Parent);
                parentNode = trvAccounts.SelectedNode.Parent;
            }

            // Account creation dialog
            FormCreate dialog;
            if (additionCase == AdditionCase.AccountSingle)
            {
                dialog = new FormCreate(db, true, "Создание счета", "Название счета:");
            }
            else
            {
                dialog = new FormCreate(db, false, "Создание группы счетов", "Название группы счетов:");
            }
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            string inputName = dialog.InputName.Trim();
            string inputCurrency = dialog.InputCurrency.Trim();

            // Check for name uniqueness
            if (db.Account.Any(x => x.Name == inputName))
            {
                MessageBox.Show(String.Format("Cчет или группа счетов с именем '{0}' уже существует.", inputName),
                    "Ошибка создания счета", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Account creation
            Account account = new Account();
            if (additionCase == AdditionCase.AccountGroup)
            {
                account.IsFolder = true;
                account.Currency = null;
            }
            else
            {
                account.IsFolder = false;
                account.Currency = db.Currency.Single(x => x.NameFull == inputCurrency).Id;
            }
            account.Parent = parentAccount.Id;
            account.Name = inputName;

            // Order number calculation
            IEnumerable<Account> accountsInGroup = db.Account.Where(x => x.Parent == account.Parent);

            if (accountsInGroup.Count() == 0)
                account.OrderNumber = 1;
            else
            {
                int maxNumber = accountsInGroup.Select(x => x.OrderNumber).Max();
                account.OrderNumber = maxNumber + 1;
            }

            // Saving to DB
            db.Account.InsertOnSubmit(account);
            db.SubmitChanges();

            // Addition new node in tree view
            TreeNode node = new TreeNode(account.Name);
            node.Tag = account;
            parentNode.Nodes.Add(node);

            trvAccounts.ExpandAll();
            trvAccounts.SelectedNode = node;
        }

        private void btnCreateItemGroup_Click(object sender, EventArgs e)
        {
            CreateItem(AdditionCase.ItemGroup);
        }

        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            CreateItem(AdditionCase.ItemSingle);
        }

        private void CreateItem(AdditionCase additionCase)
        {
            // Identifying a group where new item shall be created
            Item parentItem = (Item)trvItems.SelectedNode.Tag;
            TreeNode parentNode = trvItems.SelectedNode;
            if (!parentItem.IsFolder)
            {
                parentItem = db.Item.Single(x => x.Id == parentItem.Parent);
                parentNode = trvItems.SelectedNode.Parent;
            }

            // Item creation dialog
            FormCreate dialog;
            if (additionCase == AdditionCase.AccountSingle)
            {
                dialog = new FormCreate(db, false, "Создание статьи", "Название статьи:");
            }
            else
            {
                dialog = new FormCreate(db, false, "Создание группы статей", "Название группы статей:");
            }
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            string inputName = dialog.InputName.Trim();

            // Check for name uniqueness
            if (db.Item.Any(x => x.Name == inputName))
            {
                MessageBox.Show(String.Format("Статья или группа статей с именем '{0}' уже существует.", inputName),
                    "Ошибка создания статьи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Item creation
            Item item = new Item();
            item.IsFolder = (additionCase == AdditionCase.ItemGroup);
            item.Parent = parentItem.Id;
            item.Name = inputName;

            // Order number calculation
            IEnumerable<Item> itemsInGroup = db.Item.Where(x => x.Parent == item.Parent);

            if (itemsInGroup.Count() == 0)
                item.OrderNumber = 1;
            else
            {
                int maxNumber = itemsInGroup.Select(x => x.OrderNumber).Max();
                item.OrderNumber = maxNumber + 1;
            }

            // Saving to DB
            db.Item.InsertOnSubmit(item);
            db.SubmitChanges();

            // Addition new node in tree view
            TreeNode node = new TreeNode(item.Name);
            node.Tag = item;
            parentNode.Nodes.Add(node);

            trvItems.ExpandAll();
            trvItems.SelectedNode = node;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            // TODO: support check for in use accounts and accounts in groups
            // TODO: add confirmation
            // Supports delete of accounts and account groups
            Account account = (Account)trvAccounts.SelectedNode.Tag;
            if (account.Parent == null)
                return;

            if (account.IsFolder)
            {
                IEnumerable<Account> deletingAccounts = db.Account.Where(x => x.Parent == account.Id);
                foreach (Account deletingAccount in deletingAccounts)
                {
                    db.Account.DeleteOnSubmit(deletingAccount);
                }
            }

            db.Account.DeleteOnSubmit(account);
            IEnumerable<Account> changingAccounts = db.Account.Where(x => x.Parent == account.Parent && x.OrderNumber > account.OrderNumber);
            foreach (Account changingAccount in changingAccounts)
            {
                changingAccount.OrderNumber--;
            }

            db.SubmitChanges();

            TreeNode node = trvAccounts.SelectedNode;
            node.Parent.Nodes.Remove(node);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            // TODO: support check for in use items and items in groups
            // TODO: add confirmation
            // Supports delete of items and item groups
            Item item = (Item)trvItems.SelectedNode.Tag;
            if (item.Parent == null)
                return;

            if (item.IsFolder)
            {
                IEnumerable<Item> deletingItems = db.Item.Where(x => x.Parent == item.Id);
                foreach (Item deletingItem in deletingItems)
                {
                    db.Item.DeleteOnSubmit(deletingItem);
                }
            }

            db.Item.DeleteOnSubmit(item);
            IEnumerable<Item> changingItems = db.Item.Where(x => x.Parent == item.Parent && x.OrderNumber > item.OrderNumber);
            foreach (Item changingItem in changingItems)
            {
                changingItem.OrderNumber--;
            }

            db.SubmitChanges();

            TreeNode node = trvItems.SelectedNode;
            node.Parent.Nodes.Remove(node);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            // Supports edit of accounts and account groups

            Account account = (Account)trvAccounts.SelectedNode.Tag;

            // Account edit dialog
            FormCreate dialog;
            if (!account.IsFolder)
            {
                dialog = new FormCreate(db, false, "Редактирование счета", "Название счета:", account.Name);
            }
            else
            {
                dialog = new FormCreate(db, false, "Редактирование группы счетов", "Название группы счетов:", account.Name);
            }
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            string inputName = dialog.InputName.Trim();

            // Check for name uniqueness
            if (db.Account.Any(x => x.Name == inputName))
            {
                MessageBox.Show(String.Format("Счет или группа счетов с именем '{0}' уже существует.", inputName),
                    "Ошибка создания статьи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Saving to DB
            account.Name = inputName;
            db.SubmitChanges();

            // Change node text in tree view
            TreeNode node = trvAccounts.SelectedNode;
            node.Text = account.Name;
            node.Tag = account;
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            // Supports edit of items and item groups

            Item item = (Item)trvItems.SelectedNode.Tag;

            // Item edit dialog
            FormCreate dialog;
            if (!item.IsFolder)
            {
                dialog = new FormCreate(db, false, "Редактирование статьи", "Название статьи:", item.Name);
            }
            else
            {
                dialog = new FormCreate(db, false, "Редактирование группы статей", "Название группы статей:", item.Name);
            }
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            string inputName = dialog.InputName.Trim();

            // Check for name uniqueness
            if (db.Item.Any(x => x.Name == inputName))
            {
                MessageBox.Show(String.Format("Статья или группа статей с именем '{0}' уже существует.", inputName),
                    "Ошибка создания статьи", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Saving to DB
            item.Name = inputName;
            db.SubmitChanges();

            // Change node text in tree view
            TreeNode node = trvItems.SelectedNode;
            node.Text = item.Name;
            node.Tag = item;
        }

        private void btnAccountUp_Click(object sender, EventArgs e)
        {
            MoveAccount(MoveDirection.Up);
        }

        private void btnAccountDown_Click(object sender, EventArgs e)
        {
            MoveAccount(MoveDirection.Down);
        }

        private void MoveAccount(MoveDirection moveDirection)
        {
            Account account = (Account)trvAccounts.SelectedNode.Tag;
            int orderNumber = account.OrderNumber;
            int otherNumber;

            TreeNode node = trvAccounts.SelectedNode;
            TreeNodeCollection parentNodes = node.Parent.Nodes;
            int index = node.Index;
            int newIndex;

            if (moveDirection == MoveDirection.Up)
            {
                if (orderNumber == 1)
                    return;
                otherNumber = orderNumber - 1;
                newIndex = index - 1;
            }
            else
            {
                int maxNumber = db.Account.Where(x => x.Parent == account.Parent).Select(x => x.OrderNumber).Max();
                if (orderNumber == maxNumber)
                    return;
                otherNumber = orderNumber + 1;
                newIndex = index + 1;
            }

            Account otherAccount = db.Account
                .Single(x => x.Parent == account.Parent && x.OrderNumber == otherNumber);
            account.OrderNumber = otherNumber;
            otherAccount.OrderNumber = orderNumber;

            db.SubmitChanges();

            parentNodes.RemoveAt(index);
            parentNodes.Insert(newIndex, node);
            trvAccounts.SelectedNode = node;

            trvAccounts.Refresh();
        }

        private void btnItemUp_Click(object sender, EventArgs e)
        {
            MoveItem(MoveDirection.Up);
        }

        private void btnItemDown_Click(object sender, EventArgs e)
        {
            MoveItem(MoveDirection.Down);
        }

        private void MoveItem(MoveDirection moveDirection)
        {
            Item item = (Item)trvItems.SelectedNode.Tag;
            int orderNumber = item.OrderNumber;
            int otherNumber;

            TreeNode node = trvItems.SelectedNode;
            TreeNodeCollection parentNodes = node.Parent.Nodes;
            int index = node.Index;
            int newIndex;

            if (moveDirection == MoveDirection.Up)
            {
                if (orderNumber == 1)
                    return;
                otherNumber = orderNumber - 1;
                newIndex = index - 1;
            }
            else
            {
                int maxNumber = db.Item.Where(x => x.Parent == item.Parent).Select(x => x.OrderNumber).Max();
                if (orderNumber == maxNumber)
                    return;
                otherNumber = orderNumber + 1;
                newIndex = index + 1;
            }

            Item otherItem = db.Item
                .Single(x => x.Parent == item.Parent && x.OrderNumber == otherNumber);
            item.OrderNumber = otherNumber;
            otherItem.OrderNumber = orderNumber;

            db.SubmitChanges();

            parentNodes.RemoveAt(index);
            parentNodes.Insert(newIndex, node);
            trvItems.SelectedNode = node;

            trvItems.Refresh();
        }

        private void btnAddCurrency_Click(object sender, EventArgs e)
        {
            // TODO: 1) select newly added currency
            // TODO: 2) Identify row with checked main currency easier, without loop over all rows

            // Currency creation dialog
            FormCreateCurrency dialog = new FormCreateCurrency();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            string nameShort = dialog.ShortName.Trim();
            string nameFull = dialog.FullName.Trim();

            // Check for name uniqueness
            if (db.Currency.Any(x => x.NameShort == nameShort))
            {
                MessageBox.Show(String.Format("Валюта с коротким наменованием '{0}' уже существует.", nameShort),
                    "Ошибка создания валюты", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.Currency.Any(x => x.NameFull == nameFull))
            {
                MessageBox.Show(String.Format("Валюта с полным наменованием '{0}' уже существует.", nameFull),
                    "Ошибка создания валюты", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Currency creation
            Currency currency = new Currency();
            currency.NameShort = nameShort;
            currency.NameFull = nameFull;

            // Order number calculation
            IEnumerable<Currency> currencies = db.Currency.Where(x => true);

            if (currencies.Count() == 0)
                currency.OrderNumber = 1;
            else
            {
                int maxNumber = currencies.Select(x => x.OrderNumber).Max();
                currency.OrderNumber = maxNumber + 1;
            }

            // Main currency handling
            if (currencies.Count() == 0)
                currency.IsMain = true;
            else if (dialog.MainCurrency)
            {
                currency.IsMain = true;
                Currency prevMainCurrency = db.Currency.Single(x => x.IsMain);
                prevMainCurrency.IsMain = false;

                foreach (DataGridViewRow row in dgvCurrencies.Rows)
                {
                    if ((bool)row.Cells["mainCurrency"].Value)
                    {
                        row.Cells["mainCurrency"].Value = false;
                        break;
                    }
                }
            }

            // Saving to DB
            db.Currency.InsertOnSubmit(currency);
            db.SubmitChanges();

            // Addition new currency in data grid view
            int index = dgvCurrencies.Rows.Add(currency.OrderNumber, currency.NameFull, currency.NameShort, currency.IsMain);
            dgvCurrencies.Rows[index].Tag = currency;
            // dgvCurrencies.Rows[index].Selected = true; // does not work
        }

        private void btnDeleteCurrency_Click(object sender, EventArgs e)
        {
            // TODO: support check for in use currencies
            // TODO: add confirmation
            // TODO: implement SQL check for single main currency

            DataGridViewRow selectedRow = dgvCurrencies.SelectedCells[0].OwningRow;
            Currency currency = (Currency)selectedRow.Tag;

            // Check for not allowed delete of the main currency
            if (currency.IsMain)
            {
                MessageBox.Show("Нельзя удалить основную валюту.", "Ошибка удаления валюты", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Currency.DeleteOnSubmit(currency);

            IEnumerable<Currency> changingCurrencies = db.Currency.Where(x => x.OrderNumber > currency.OrderNumber);
            foreach (Currency changingCurrency in changingCurrencies)
            {
                changingCurrency.OrderNumber--;
            }

            db.SubmitChanges();

            dgvCurrencies.Rows.Remove(selectedRow);
            foreach (DataGridViewRow row in dgvCurrencies.Rows)
            {
                row.Cells["number"].Value = ((Currency)row.Tag).OrderNumber;
            }
        }

    }
}
