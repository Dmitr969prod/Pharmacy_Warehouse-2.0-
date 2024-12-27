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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MedicinesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuppliersComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Дата поступления на склад(ГГ.ММ.ДД)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 301);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 38);
            this.textBox1.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Номер накладной";
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(12, 219);
            this.IdBox.Multiline = true;
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(273, 38);
            this.IdBox.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Выберите лекарство";
            // 
            // MedicinesComboBox
            // 
            this.MedicinesComboBox.FormattingEnabled = true;
            this.MedicinesComboBox.Location = new System.Drawing.Point(12, 134);
            this.MedicinesComboBox.Name = "MedicinesComboBox";
            this.MedicinesComboBox.Size = new System.Drawing.Size(273, 28);
            this.MedicinesComboBox.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Выберите поставщика";
            // 
            // SuppliersComboBox
            // 
            this.SuppliersComboBox.FormattingEnabled = true;
            this.SuppliersComboBox.Location = new System.Drawing.Point(12, 52);
            this.SuppliersComboBox.Name = "SuppliersComboBox";
            this.SuppliersComboBox.Size = new System.Drawing.Size(273, 28);
            this.SuppliersComboBox.TabIndex = 66;
            // 
            // AddDelievery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 376);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MedicinesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SuppliersComboBox;
    }
}