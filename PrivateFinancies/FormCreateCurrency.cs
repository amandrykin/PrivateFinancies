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
    public partial class FormCreateCurrency : Form
    {
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public bool MainCurrency { get; set; }

        public FormCreateCurrency()
        {
            InitializeComponent();
        }
        
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidateNames();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            ValidateNames();
        }

        private void ValidateNames()
        {
            if (txtShortName.Text != "" && txtFullName.Text != "")
                btnOK.Enabled = true;
            else
                btnOK.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ShortName = txtShortName.Text;
            FullName = txtFullName.Text;
            MainCurrency = chbMainCurrency.Checked;
            DialogResult = DialogResult.OK;
        }
    }
}
