namespace PrivateFinancies
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.tabCurrencies = new System.Windows.Forms.TabPage();
            this.dgvCurrencies = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainCurrency = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAddCurrency = new System.Windows.Forms.Button();
            this.btnCurrencyDown = new System.Windows.Forms.Button();
            this.btnCurrencyUp = new System.Windows.Forms.Button();
            this.btnDeleteCurrency = new System.Windows.Forms.Button();
            this.btnEditCurrency = new System.Windows.Forms.Button();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.btnCreateItemGroup = new System.Windows.Forms.Button();
            this.btnItemDown = new System.Windows.Forms.Button();
            this.btnItemUp = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.trvItems = new System.Windows.Forms.TreeView();
            this.tabAccounts = new System.Windows.Forms.TabPage();
            this.btnAccountDown = new System.Windows.Forms.Button();
            this.btnAccountUp = new System.Windows.Forms.Button();
            this.btCreateAccountGroup = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.trvAccounts = new System.Windows.Forms.TreeView();
            this.tabOperations = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabCurrencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).BeginInit();
            this.tabItems.SuspendLayout();
            this.tabAccounts.SuspendLayout();
            this.tabOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCourses
            // 
            this.tabCourses.Location = new System.Drawing.Point(4, 22);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Size = new System.Drawing.Size(703, 338);
            this.tabCourses.TabIndex = 4;
            this.tabCourses.Text = "Курсы валют";
            this.tabCourses.UseVisualStyleBackColor = true;
            // 
            // tabCurrencies
            // 
            this.tabCurrencies.Controls.Add(this.dgvCurrencies);
            this.tabCurrencies.Controls.Add(this.btnAddCurrency);
            this.tabCurrencies.Controls.Add(this.btnCurrencyDown);
            this.tabCurrencies.Controls.Add(this.btnCurrencyUp);
            this.tabCurrencies.Controls.Add(this.btnDeleteCurrency);
            this.tabCurrencies.Controls.Add(this.btnEditCurrency);
            this.tabCurrencies.Location = new System.Drawing.Point(4, 22);
            this.tabCurrencies.Name = "tabCurrencies";
            this.tabCurrencies.Size = new System.Drawing.Size(703, 338);
            this.tabCurrencies.TabIndex = 3;
            this.tabCurrencies.Text = "Валюты";
            this.tabCurrencies.UseVisualStyleBackColor = true;
            // 
            // dgvCurrencies
            // 
            this.dgvCurrencies.AllowUserToAddRows = false;
            this.dgvCurrencies.AllowUserToResizeRows = false;
            this.dgvCurrencies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCurrencies.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCurrencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.fullName,
            this.shortName,
            this.mainCurrency});
            this.dgvCurrencies.Location = new System.Drawing.Point(0, 0);
            this.dgvCurrencies.MultiSelect = false;
            this.dgvCurrencies.Name = "dgvCurrencies";
            this.dgvCurrencies.RowHeadersVisible = false;
            this.dgvCurrencies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCurrencies.Size = new System.Drawing.Size(583, 338);
            this.dgvCurrencies.TabIndex = 16;
            // 
            // number
            // 
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 30;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Полное наименование";
            this.fullName.MaxInputLength = 20;
            this.fullName.Name = "fullName";
            this.fullName.Width = 150;
            // 
            // shortName
            // 
            this.shortName.HeaderText = "Короткое наименование";
            this.shortName.MaxInputLength = 3;
            this.shortName.Name = "shortName";
            this.shortName.Width = 150;
            // 
            // mainCurrency
            // 
            this.mainCurrency.HeaderText = "Основная валюта";
            this.mainCurrency.Name = "mainCurrency";
            this.mainCurrency.Width = 110;
            // 
            // btnAddCurrency
            // 
            this.btnAddCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCurrency.Location = new System.Drawing.Point(589, 6);
            this.btnAddCurrency.Name = "btnAddCurrency";
            this.btnAddCurrency.Size = new System.Drawing.Size(106, 23);
            this.btnAddCurrency.TabIndex = 15;
            this.btnAddCurrency.Text = "Добавить";
            this.btnAddCurrency.UseVisualStyleBackColor = true;
            this.btnAddCurrency.Click += new System.EventHandler(this.btnAddCurrency_Click);
            // 
            // btnCurrencyDown
            // 
            this.btnCurrencyDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrencyDown.Location = new System.Drawing.Point(644, 105);
            this.btnCurrencyDown.Name = "btnCurrencyDown";
            this.btnCurrencyDown.Size = new System.Drawing.Size(50, 23);
            this.btnCurrencyDown.TabIndex = 14;
            this.btnCurrencyDown.Text = "Вниз";
            this.btnCurrencyDown.UseVisualStyleBackColor = true;
            // 
            // btnCurrencyUp
            // 
            this.btnCurrencyUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrencyUp.Location = new System.Drawing.Point(589, 105);
            this.btnCurrencyUp.Name = "btnCurrencyUp";
            this.btnCurrencyUp.Size = new System.Drawing.Size(50, 23);
            this.btnCurrencyUp.TabIndex = 13;
            this.btnCurrencyUp.Text = "Вверх";
            this.btnCurrencyUp.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCurrency
            // 
            this.btnDeleteCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCurrency.Location = new System.Drawing.Point(589, 64);
            this.btnDeleteCurrency.Name = "btnDeleteCurrency";
            this.btnDeleteCurrency.Size = new System.Drawing.Size(106, 23);
            this.btnDeleteCurrency.TabIndex = 12;
            this.btnDeleteCurrency.Text = "Удалить";
            this.btnDeleteCurrency.UseVisualStyleBackColor = true;
            this.btnDeleteCurrency.Click += new System.EventHandler(this.btnDeleteCurrency_Click);
            // 
            // btnEditCurrency
            // 
            this.btnEditCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCurrency.Location = new System.Drawing.Point(589, 35);
            this.btnEditCurrency.Name = "btnEditCurrency";
            this.btnEditCurrency.Size = new System.Drawing.Size(106, 23);
            this.btnEditCurrency.TabIndex = 11;
            this.btnEditCurrency.Text = "Изменить";
            this.btnEditCurrency.UseVisualStyleBackColor = true;
            // 
            // tabItems
            // 
            this.tabItems.Controls.Add(this.btnCreateItemGroup);
            this.tabItems.Controls.Add(this.btnItemDown);
            this.tabItems.Controls.Add(this.btnItemUp);
            this.tabItems.Controls.Add(this.btnDeleteItem);
            this.tabItems.Controls.Add(this.btnCreateItem);
            this.tabItems.Controls.Add(this.trvItems);
            this.tabItems.Location = new System.Drawing.Point(4, 22);
            this.tabItems.Name = "tabItems";
            this.tabItems.Size = new System.Drawing.Size(703, 338);
            this.tabItems.TabIndex = 2;
            this.tabItems.Text = "Статьи";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // btnCreateItemGroup
            // 
            this.btnCreateItemGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateItemGroup.Location = new System.Drawing.Point(589, 6);
            this.btnCreateItemGroup.Name = "btnCreateItemGroup";
            this.btnCreateItemGroup.Size = new System.Drawing.Size(106, 23);
            this.btnCreateItemGroup.TabIndex = 10;
            this.btnCreateItemGroup.Text = "Создать группу";
            this.btnCreateItemGroup.UseVisualStyleBackColor = true;
            this.btnCreateItemGroup.Click += new System.EventHandler(this.btnCreateItemGroup_Click);
            // 
            // btnItemDown
            // 
            this.btnItemDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemDown.Location = new System.Drawing.Point(644, 105);
            this.btnItemDown.Name = "btnItemDown";
            this.btnItemDown.Size = new System.Drawing.Size(50, 23);
            this.btnItemDown.TabIndex = 9;
            this.btnItemDown.Text = "Вниз";
            this.btnItemDown.UseVisualStyleBackColor = true;
            this.btnItemDown.Click += new System.EventHandler(this.btnItemDown_Click);
            // 
            // btnItemUp
            // 
            this.btnItemUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemUp.Location = new System.Drawing.Point(589, 105);
            this.btnItemUp.Name = "btnItemUp";
            this.btnItemUp.Size = new System.Drawing.Size(50, 23);
            this.btnItemUp.TabIndex = 8;
            this.btnItemUp.Text = "Вверх";
            this.btnItemUp.UseVisualStyleBackColor = true;
            this.btnItemUp.Click += new System.EventHandler(this.btnItemUp_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteItem.Location = new System.Drawing.Point(589, 64);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(106, 23);
            this.btnDeleteItem.TabIndex = 4;
            this.btnDeleteItem.Text = "Удалить";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateItem.Location = new System.Drawing.Point(589, 35);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(106, 23);
            this.btnCreateItem.TabIndex = 3;
            this.btnCreateItem.Text = "Создать статью";
            this.btnCreateItem.UseVisualStyleBackColor = true;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // trvItems
            // 
            this.trvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvItems.HideSelection = false;
            this.trvItems.Location = new System.Drawing.Point(0, 0);
            this.trvItems.Name = "trvItems";
            this.trvItems.Size = new System.Drawing.Size(583, 338);
            this.trvItems.TabIndex = 2;
            // 
            // tabAccounts
            // 
            this.tabAccounts.Controls.Add(this.btnAccountDown);
            this.tabAccounts.Controls.Add(this.btnAccountUp);
            this.tabAccounts.Controls.Add(this.btCreateAccountGroup);
            this.tabAccounts.Controls.Add(this.btnDeleteAccount);
            this.tabAccounts.Controls.Add(this.btnCreateAccount);
            this.tabAccounts.Controls.Add(this.trvAccounts);
            this.tabAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccounts.Size = new System.Drawing.Size(703, 338);
            this.tabAccounts.TabIndex = 1;
            this.tabAccounts.Text = "Счета";
            this.tabAccounts.UseVisualStyleBackColor = true;
            // 
            // btnAccountDown
            // 
            this.btnAccountDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountDown.Location = new System.Drawing.Point(644, 105);
            this.btnAccountDown.Name = "btnAccountDown";
            this.btnAccountDown.Size = new System.Drawing.Size(50, 23);
            this.btnAccountDown.TabIndex = 7;
            this.btnAccountDown.Text = "Вниз";
            this.btnAccountDown.UseVisualStyleBackColor = true;
            this.btnAccountDown.Click += new System.EventHandler(this.btnAccountDown_Click);
            // 
            // btnAccountUp
            // 
            this.btnAccountUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountUp.Location = new System.Drawing.Point(589, 105);
            this.btnAccountUp.Name = "btnAccountUp";
            this.btnAccountUp.Size = new System.Drawing.Size(50, 23);
            this.btnAccountUp.TabIndex = 6;
            this.btnAccountUp.Text = "Вверх";
            this.btnAccountUp.UseVisualStyleBackColor = true;
            this.btnAccountUp.Click += new System.EventHandler(this.btnAccountUp_Click);
            // 
            // btCreateAccountGroup
            // 
            this.btCreateAccountGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateAccountGroup.Location = new System.Drawing.Point(589, 6);
            this.btCreateAccountGroup.Name = "btCreateAccountGroup";
            this.btCreateAccountGroup.Size = new System.Drawing.Size(106, 23);
            this.btCreateAccountGroup.TabIndex = 4;
            this.btCreateAccountGroup.Text = "Создать группу";
            this.btCreateAccountGroup.UseVisualStyleBackColor = true;
            this.btCreateAccountGroup.Click += new System.EventHandler(this.btCreateAccountGroup_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(589, 64);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(106, 23);
            this.btnDeleteAccount.TabIndex = 3;
            this.btnDeleteAccount.Text = "Удалить";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateAccount.Location = new System.Drawing.Point(589, 35);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(106, 23);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Создать счет";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // trvAccounts
            // 
            this.trvAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvAccounts.HideSelection = false;
            this.trvAccounts.Location = new System.Drawing.Point(0, 0);
            this.trvAccounts.Name = "trvAccounts";
            this.trvAccounts.Size = new System.Drawing.Size(583, 338);
            this.trvAccounts.TabIndex = 1;
            // 
            // tabOperations
            // 
            this.tabOperations.Controls.Add(this.dataGridView1);
            this.tabOperations.Location = new System.Drawing.Point(4, 22);
            this.tabOperations.Name = "tabOperations";
            this.tabOperations.Padding = new System.Windows.Forms.Padding(3);
            this.tabOperations.Size = new System.Drawing.Size(703, 338);
            this.tabOperations.TabIndex = 0;
            this.tabOperations.Text = "Операции";
            this.tabOperations.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tabOperations);
            this.tcMain.Controls.Add(this.tabAccounts);
            this.tcMain.Controls.Add(this.tabItems);
            this.tcMain.Controls.Add(this.tabCurrencies);
            this.tcMain.Controls.Add(this.tabCourses);
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(711, 364);
            this.tcMain.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 365);
            this.Controls.Add(this.tcMain);
            this.MinimumSize = new System.Drawing.Size(280, 200);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.tabCurrencies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).EndInit();
            this.tabItems.ResumeLayout(false);
            this.tabAccounts.ResumeLayout(false);
            this.tabOperations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabCourses;
        private System.Windows.Forms.TabPage tabCurrencies;
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.TabPage tabAccounts;
        private System.Windows.Forms.TabPage tabOperations;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TreeView trvAccounts;
        private System.Windows.Forms.Button btCreateAccountGroup;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnAccountDown;
        private System.Windows.Forms.Button btnAccountUp;
        private System.Windows.Forms.TreeView trvItems;
        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.Button btnItemDown;
        private System.Windows.Forms.Button btnItemUp;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnCreateItemGroup;
        private System.Windows.Forms.Button btnAddCurrency;
        private System.Windows.Forms.Button btnCurrencyDown;
        private System.Windows.Forms.Button btnCurrencyUp;
        private System.Windows.Forms.Button btnDeleteCurrency;
        private System.Windows.Forms.Button btnEditCurrency;
        private System.Windows.Forms.DataGridView dgvCurrencies;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mainCurrency;
    }
}

