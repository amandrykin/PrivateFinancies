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
    public partial class FormCreate : Form
    {
        public string InputName { get; set; }
        public string InputCurrency { get; set; }
        private frmMain.AdditionCase additionCase;

        public FormCreate(DataClasses1DataContext db, frmMain.AdditionCase additionCase)
        {
            // TODO: 1) Get all currencies easier, without Where()

            InitializeComponent();

            this.additionCase = additionCase;

            if (additionCase == frmMain.AdditionCase.AccountSingle)
            {
                cmbCurrency.Items.Clear();
                IEnumerable<Currency> currencies = db.Currency.Where(x => true);
                int mainCurrencyIndex = 0;
                foreach (Currency currency in currencies)
                {
                    int index = cmbCurrency.Items.Add(currency.NameFull);
                    if (currency.IsMain)
                        mainCurrencyIndex = index;
                }
                cmbCurrency.SelectedIndex = mainCurrencyIndex;
            }
            else
            {
                lblCurrency.Visible = false;
                cmbCurrency.Visible = false;
            }

            switch (additionCase)
            {
                case frmMain.AdditionCase.AccountSingle:
                    break;  // default values are valid
                case frmMain.AdditionCase.AccountGroup:
                    Text = "Создание группы счетов";
                    lblName.Text = "Название группы счетов";
                    break;
                case frmMain.AdditionCase.ItemSingle:
                    Text = "Создание статьи";
                    lblName.Text = "Название статьи";
                    break;
                case frmMain.AdditionCase.ItemGroup:
                    Text = "Создание группы статей";
                    lblName.Text = "Название группы статей";
                    break;
                default:
                    break;
            }

            txtName.Focus();
        }
        
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "")
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            InputName = txtName.Text;

            if (additionCase == frmMain.AdditionCase.AccountSingle)
            {
                InputCurrency = (string)cmbCurrency.SelectedItem;
            }
            else
            {
                InputCurrency = "";
            }

            DialogResult = DialogResult.OK;
        }
    }
}
