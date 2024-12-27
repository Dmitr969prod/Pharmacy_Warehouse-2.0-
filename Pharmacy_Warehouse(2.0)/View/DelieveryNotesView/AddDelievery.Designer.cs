namespace Pharmacy_Warehouse_2._0_.View.DelieveryNotesView
{
    partial class AddDelievery
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
            this.label4 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MedicinesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuppliersComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ComeBackButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Дата поступления на склад(ДД.ММ.ГГГГ)";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(73, 318);
            this.DateBox.Multiline = true;
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(273, 38);
            this.DateBox.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Номер накладной";
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(73, 236);
            this.IdBox.Multiline = true;
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(273, 38);
            this.IdBox.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Выберите лекарство";
            // 
            // MedicinesComboBox
            // 
            this.MedicinesComboBox.FormattingEnabled = true;
            this.MedicinesComboBox.Location = new System.Drawing.Point(73, 151);
            this.MedicinesComboBox.Name = "MedicinesComboBox";
            this.MedicinesComboBox.Size = new System.Drawing.Size(273, 28);
            this.MedicinesComboBox.TabIndex = 68;
            this.MedicinesComboBox.SelectedIndexChanged += new System.EventHandler(this.MedicinesComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Выберите поставщика";
            // 
            // SuppliersComboBox
            // 
            this.SuppliersComboBox.FormattingEnabled = true;
            this.SuppliersComboBox.Location = new System.Drawing.Point(73, 69);
            this.SuppliersComboBox.Name = "SuppliersComboBox";
            this.SuppliersComboBox.Size = new System.Drawing.Size(273, 28);
            this.SuppliersComboBox.TabIndex = 66;
            this.SuppliersComboBox.SelectedIndexChanged += new System.EventHandler(this.SuppliersComboBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(282, 618);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 32);
            this.AddButton.TabIndex = 75;
            this.AddButton.Text = "Создать";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ComeBackButton
            // 
            this.ComeBackButton.Location = new System.Drawing.Point(12, 8);
            this.ComeBackButton.Name = "ComeBackButton";
            this.ComeBackButton.Size = new System.Drawing.Size(94, 32);
            this.ComeBackButton.TabIndex = 76;
            this.ComeBackButton.Text = "Назад";
            this.ComeBackButton.UseVisualStyleBackColor = true;
            this.ComeBackButton.Click += new System.EventHandler(this.ComeBackButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Количество";
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(73, 476);
            this.CountBox.Multiline = true;
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(273, 38);
            this.CountBox.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 78;
            this.label6.Text = "Цена за штуку";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(73, 394);
            this.PriceBox.Multiline = true;
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(273, 38);
            this.PriceBox.TabIndex = 77;
            // 
            // AddDelievery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 662);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.ComeBackButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MedicinesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SuppliersComboBox);
            this.Name = "AddDelievery";
            this.Text = "AddDelievery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MedicinesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SuppliersComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ComeBackButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PriceBox;
    }
}