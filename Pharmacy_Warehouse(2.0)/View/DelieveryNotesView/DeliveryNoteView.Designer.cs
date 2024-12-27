namespace Pharmacy_Warehouse_2._0_.View.DelieveryNoteView
{
    partial class DeliveryNoteView
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
            this.ComeBackButton = new System.Windows.Forms.Button();
            this.DeliveryNotesListBox = new System.Windows.Forms.ListBox();
            this.MedicineListLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MedicineNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SupplierNameBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dd = new System.Windows.Forms.Label();
            this.PricePerUnitBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComeBackButton
            // 
            this.ComeBackButton.Location = new System.Drawing.Point(17, 21);
            this.ComeBackButton.Name = "ComeBackButton";
            this.ComeBackButton.Size = new System.Drawing.Size(79, 31);
            this.ComeBackButton.TabIndex = 57;
            this.ComeBackButton.Text = "Назад";
            this.ComeBackButton.UseVisualStyleBackColor = true;
            this.ComeBackButton.Click += new System.EventHandler(this.ComeBackButton_Click_1);
            // 
            // DeliveryNotesListBox
            // 
            this.DeliveryNotesListBox.FormattingEnabled = true;
            this.DeliveryNotesListBox.ItemHeight = 20;
            this.DeliveryNotesListBox.Location = new System.Drawing.Point(60, 88);
            this.DeliveryNotesListBox.Name = "DeliveryNotesListBox";
            this.DeliveryNotesListBox.Size = new System.Drawing.Size(682, 324);
            this.DeliveryNotesListBox.TabIndex = 56;
            this.DeliveryNotesListBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryNotesListBox_SelectedIndexChanged_1);
            // 
            // MedicineListLabel
            // 
            this.MedicineListLabel.AutoSize = true;
            this.MedicineListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MedicineListLabel.Location = new System.Drawing.Point(121, 21);
            this.MedicineListLabel.Name = "MedicineListLabel";
            this.MedicineListLabel.Size = new System.Drawing.Size(275, 37);
            this.MedicineListLabel.TabIndex = 55;
            this.MedicineListLabel.Text = "Список поставок";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(538, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 33);
            this.button2.TabIndex = 59;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 60;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(812, 88);
            this.IdTextBox.Multiline = true;
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(347, 41);
            this.IdTextBox.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(812, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Номер приходной накладной ведомости";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(812, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Дата поступления на склад";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(811, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Поступивший товар";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MedicineNameBox
            // 
            this.MedicineNameBox.Location = new System.Drawing.Point(815, 277);
            this.MedicineNameBox.Multiline = true;
            this.MedicineNameBox.Name = "MedicineNameBox";
            this.MedicineNameBox.ReadOnly = true;
            this.MedicineNameBox.Size = new System.Drawing.Size(347, 41);
            this.MedicineNameBox.TabIndex = 65;
            this.MedicineNameBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(808, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Поставщик";
            // 
            // SupplierNameBox
            // 
            this.SupplierNameBox.Location = new System.Drawing.Point(812, 210);
            this.SupplierNameBox.Multiline = true;
            this.SupplierNameBox.Name = "SupplierNameBox";
            this.SupplierNameBox.ReadOnly = true;
            this.SupplierNameBox.Size = new System.Drawing.Size(347, 41);
            this.SupplierNameBox.TabIndex = 67;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(816, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Location = new System.Drawing.Point(808, 328);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(117, 20);
            this.dd.TabIndex = 71;
            this.dd.Text = "Цена за штуку";
            // 
            // PricePerUnitBox
            // 
            this.PricePerUnitBox.Location = new System.Drawing.Point(812, 351);
            this.PricePerUnitBox.Multiline = true;
            this.PricePerUnitBox.Name = "PricePerUnitBox";
            this.PricePerUnitBox.ReadOnly = true;
            this.PricePerUnitBox.Size = new System.Drawing.Size(347, 41);
            this.PricePerUnitBox.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(808, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Количество";
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(812, 429);
            this.QuantityBox.Multiline = true;
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.ReadOnly = true;
            this.QuantityBox.Size = new System.Drawing.Size(347, 41);
            this.QuantityBox.TabIndex = 72;
            // 
            // DeliveryNoteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 505);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.PricePerUnitBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SupplierNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MedicineNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ComeBackButton);
            this.Controls.Add(this.DeliveryNotesListBox);
            this.Controls.Add(this.MedicineListLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeliveryNoteView";
            this.Text = "DeliveryNoteView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComeBackButton;
        private System.Windows.Forms.ListBox DeliveryNotesListBox;
        private System.Windows.Forms.Label MedicineListLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MedicineNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SupplierNameBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.TextBox PricePerUnitBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox QuantityBox;
    }
}