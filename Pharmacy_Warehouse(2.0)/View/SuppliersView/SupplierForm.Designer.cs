namespace Pharmacy_Warehouse_2._0_.View.Suppliers
{
    partial class SupplierForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TaxIdBox = new System.Windows.Forms.TextBox();
            this.AccountNumberBox = new System.Windows.Forms.TextBox();
            this.BankNameBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ComeBackButton = new System.Windows.Forms.Button();
            this.SuppliersListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(812, 537);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(430, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Идентификационный номер налогоплательщика(ИНН)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(812, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Номер расчетного счета в этом банке";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(812, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Банк";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(812, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(812, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Название";
            // 
            // TaxIdBox
            // 
            this.TaxIdBox.Location = new System.Drawing.Point(816, 560);
            this.TaxIdBox.Multiline = true;
            this.TaxIdBox.Name = "TaxIdBox";
            this.TaxIdBox.ReadOnly = true;
            this.TaxIdBox.Size = new System.Drawing.Size(445, 52);
            this.TaxIdBox.TabIndex = 36;
            // 
            // AccountNumberBox
            // 
            this.AccountNumberBox.Location = new System.Drawing.Point(816, 474);
            this.AccountNumberBox.Multiline = true;
            this.AccountNumberBox.Name = "AccountNumberBox";
            this.AccountNumberBox.ReadOnly = true;
            this.AccountNumberBox.Size = new System.Drawing.Size(445, 52);
            this.AccountNumberBox.TabIndex = 35;
            // 
            // BankNameBox
            // 
            this.BankNameBox.Location = new System.Drawing.Point(816, 383);
            this.BankNameBox.Multiline = true;
            this.BankNameBox.Name = "BankNameBox";
            this.BankNameBox.ReadOnly = true;
            this.BankNameBox.Size = new System.Drawing.Size(445, 52);
            this.BankNameBox.TabIndex = 34;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(816, 298);
            this.PhoneNumberBox.Multiline = true;
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.ReadOnly = true;
            this.PhoneNumberBox.Size = new System.Drawing.Size(445, 52);
            this.PhoneNumberBox.TabIndex = 33;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(816, 218);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.ReadOnly = true;
            this.AddressBox.Size = new System.Drawing.Size(445, 52);
            this.AddressBox.TabIndex = 32;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(816, 135);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(445, 52);
            this.NameBox.TabIndex = 31;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // ComeBackButton
            // 
            this.ComeBackButton.Location = new System.Drawing.Point(3, 68);
            this.ComeBackButton.Name = "ComeBackButton";
            this.ComeBackButton.Size = new System.Drawing.Size(79, 31);
            this.ComeBackButton.TabIndex = 30;
            this.ComeBackButton.Text = "Назад";
            this.ComeBackButton.UseVisualStyleBackColor = true;
            this.ComeBackButton.Click += new System.EventHandler(this.ComeBackButton_Click);
            // 
            // SuppliersListBox
            // 
            this.SuppliersListBox.FormattingEnabled = true;
            this.SuppliersListBox.ItemHeight = 20;
            this.SuppliersListBox.Location = new System.Drawing.Point(46, 135);
            this.SuppliersListBox.Name = "SuppliersListBox";
            this.SuppliersListBox.Size = new System.Drawing.Size(682, 484);
            this.SuppliersListBox.TabIndex = 29;
            this.SuppliersListBox.SelectedIndexChanged += new System.EventHandler(this.SuppliersListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Список поставщиков";
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 740);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaxIdBox);
            this.Controls.Add(this.AccountNumberBox);
            this.Controls.Add(this.BankNameBox);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ComeBackButton);
            this.Controls.Add(this.SuppliersListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TaxIdBox;
        private System.Windows.Forms.TextBox AccountNumberBox;
        private System.Windows.Forms.TextBox BankNameBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button ComeBackButton;
        private System.Windows.Forms.ListBox SuppliersListBox;
        private System.Windows.Forms.Label label1;
    }
}