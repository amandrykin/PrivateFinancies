namespace PrivateFinancies
{
    partial class FormCreateCurrency
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.lblShortName = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.chbMainCurrency = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtShortName
            // 
            this.txtShortName.Location = new System.Drawing.Point(12, 29);
            this.txtShortName.MaxLength = 3;
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(259, 20);
            this.txtShortName.TabIndex = 0;
            this.txtShortName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblShortName
            // 
            this.lblShortName.AutoSize = true;
            this.lblShortName.Location = new System.Drawing.Point(12, 13);
            this.lblShortName.Name = "lblShortName";
            this.lblShortName.Size = new System.Drawing.Size(135, 13);
            this.lblShortName.TabIndex = 2;
            this.lblShortName.Text = "Короткое наименование:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(12, 59);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(125, 13);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Полное наименование:";
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(64, 132);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(145, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(12, 75);
            this.txtFullName.MaxLength = 20;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(259, 20);
            this.txtFullName.TabIndex = 6;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // chbMainCurrency
            // 
            this.chbMainCurrency.AutoSize = true;
            this.chbMainCurrency.Location = new System.Drawing.Point(12, 105);
            this.chbMainCurrency.Name = "chbMainCurrency";
            this.chbMainCurrency.Size = new System.Drawing.Size(116, 17);
            this.chbMainCurrency.TabIndex = 8;
            this.chbMainCurrency.Text = "Основная валюта";
            this.chbMainCurrency.UseVisualStyleBackColor = true;
            // 
            // FormCreateCurrency
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 167);
            this.Controls.Add(this.chbMainCurrency);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblShortName);
            this.Controls.Add(this.txtShortName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreateCurrency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление валюты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.Label lblShortName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.CheckBox chbMainCurrency;
    }
}