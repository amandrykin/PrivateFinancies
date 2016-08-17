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
        private bool useCurrency;

        public FormCreate(DataClasses1DataContext db, bool useCurrency, string formTitle, string labelText)
        {
            InitializeComponent();

            this.useCurrency = useCurrency;
            if (useCurrency)
            {
                cmbCurrency.Items.Clear();
                IEnumerable<Currency> currencies = db.Currency;
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

            Text = formTitle;
            lblName.Text = labelText;

            txtName.Focus();
        }

        public FormCreate(DataClasses1DataContext db, bool useCurrency, string formTitle, string labelText,
            string name) : this(db, useCurrency, formTitle, labelText)
        {
            txtName.Text = name;
        }

        public FormCreate(DataClasses1DataContext db, bool useCurrency, string formTitle, string labelText,
            string name, string currency) : this(db, useCurrency, formTitle, labelText, name)
        {
            //cmbCurrency = currency;
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

            if (useCurrency)
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
