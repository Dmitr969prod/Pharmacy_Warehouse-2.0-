namespace Pharmacy_Warehouse_2._0_
{
    partial class MainForm
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
            this.GetSupplierButton = new System.Windows.Forms.Button();
            this.CustomerOrderButton = new System.Windows.Forms.Button();
            this.DeliverButton = new System.Windows.Forms.Button();
            this.MedicineButton = new System.Windows.Forms.Button();
            this.Heading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetSupplierButton
            // 
            this.GetSupplierButton.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetSupplierButton.Location = new System.Drawing.Point(170, 241);
            this.GetSupplierButton.Name = "GetSupplierButton";
            this.GetSupplierButton.Size = new System.Drawing.Size(301, 111);
            this.GetSupplierButton.TabIndex = 11;
            this.GetSupplierButton.Text = "Список поставщиков";
            this.GetSupplierButton.UseVisualStyleBackColor = true;
            this.GetSupplierButton.Click += new System.EventHandler(this.GetSupplierButton_Click);
            // 
            // CustomerOrderButton
            // 
            this.CustomerOrderButton.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOrderButton.Location = new System.Drawing.Point(170, 539);
            this.CustomerOrderButton.Name = "CustomerOrderButton";
            this.CustomerOrderButton.Size = new System.Drawing.Size(301, 111);
            this.CustomerOrderButton.TabIndex = 10;
            this.CustomerOrderButton.Text = "Заказ от покупателя\r\n";
            this.CustomerOrderButton.UseVisualStyleBackColor = true;
            // 
            // DeliverButton
            // 
            this.DeliverButton.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliverButton.Location = new System.Drawing.Point(170, 390);
            this.DeliverButton.Name = "DeliverButton";
            this.DeliverButton.Size = new System.Drawing.Size(301, 111);
            this.DeliverButton.TabIndex = 9;
            this.DeliverButton.Text = "Новая поставка";
            this.DeliverButton.UseVisualStyleBackColor = true;
            // 
            // MedicineButton
            // 
            this.MedicineButton.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineButton.Location = new System.Drawing.Point(170, 103);
            this.MedicineButton.Name = "MedicineButton";
            this.MedicineButton.Size = new System.Drawing.Size(301, 111);
            this.MedicineButton.TabIndex = 8;
            this.MedicineButton.Text = "Ассортимент лекарств";
            this.MedicineButton.UseVisualStyleBackColor = true;
            this.MedicineButton.Click += new System.EventHandler(this.MedicineButton_Click);
            // 
            // Heading
            // 
            this.Heading.AllowDrop = true;
            this.Heading.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Heading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Heading.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heading.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Heading.Location = new System.Drawing.Point(0, 0);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(658, 714);
            this.Heading.TabIndex = 7;
            this.Heading.Text = "Аптечный склад";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 714);
            this.Controls.Add(this.GetSupplierButton);
            this.Controls.Add(this.CustomerOrderButton);
            this.Controls.Add(this.DeliverButton);
            this.Controls.Add(this.MedicineButton);
            this.Controls.Add(this.Heading);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetSupplierButton;
        private System.Windows.Forms.Button CustomerOrderButton;
        private System.Windows.Forms.Button DeliverButton;
        private System.Windows.Forms.Button MedicineButton;
        private System.Windows.Forms.Label Heading;
    }
}

