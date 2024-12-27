using Pharmacy_Warehouse;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pharmacy_Warehouse_2._0_.View.InvoiceView
{
    public partial class InvoiceView : Form, IInvoiceView
    {
        private bool _isEditMode = false;

        public event EventHandler LoadMainForm;

        public InvoiceView()
        {
            InitializeComponent();
        }

        public IList<string> InvoiceList
        {
            get { return (IList<string>)this.InvoiceListBox.DataSource; }
            set { this.InvoiceListBox.DataSource = value; }
        }

        public int SelectedInvoiceIndex
        {
            get { return this.InvoiceListBox.SelectedIndex; }
            set { if (value >= 0 && value < InvoiceListBox.Items.Count) { this.InvoiceListBox.SelectedIndex = value; } }
        }

        public string Id
        {
            get { return this.IdTextBox.Text; }
            set { this.IdTextBox.Text = value; }
        }

        public DateTime Date
        {
            get { return this.DatePicker.Value; }
            set { this.DatePicker.Value = value; }
        }

        public string CustomerName
        {
            get { return this.CustomerNameBox.Text; }
            set { this.CustomerNameBox.Text = value; }
        }

        public string SellerName
        {
            get { return this.SellerNameBox.Text; }
            set { this.SellerNameBox.Text = value; }
        }

        public string MedicineName
        {
            get { return this.medicineName.Text; }
            set { this.medicineName.Text = value; }
        }

        public decimal PricePerUnit
        {
            get { return decimal.Parse(this.PricePerUnitBox.Text); }
            set { this.PricePerUnitBox.Text = value.ToString(); }
        }

        public int Quantity
        {
            get { return int.Parse(this.QuantityBox.Text); }
            set { this.QuantityBox.Text = value.ToString(); }
        }



        public DeliveryItem DeliveryItem
        {
            get
            {
                return new DeliveryItem(
                    new Medicine(
                        name: this.MedicineName,
                        category: null,
                        manufactureDate: DateTime.MinValue,
                        expirationDate: DateTime.MinValue,
                        regNumber: null,
                        producer: null,
                        packaging: null
                    ),
                    pricePerUnit: this.PricePerUnit,
                    quantity: this.Quantity
                );
            }
            set
            {
                if (value != null)
                {
                    this.MedicineName = value.Medicine.Name;
                    this.PricePerUnit = value.PricePerUnit;
                    this.Quantity = value.Quantity;
                }
                else
                {
                    this.MedicineName = string.Empty;
                    this.PricePerUnit = 0;
                    this.Quantity = 0;
                }
            }
        }


        public Presenter.InvoicePresenter Presenter { get; set; }

        private void InvoiceListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Presenter.UpdateInvoiceView(InvoiceListBox.SelectedIndex);
        }

        private void ComeBackButton_Click_1(object sender, EventArgs e)
        {
            LoadMainForm?.Invoke(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InvoiceAdd invoiceAdd = new InvoiceAdd(Presenter);
            invoiceAdd.Show();
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            Presenter.DeleteInvoice();
            if (InvoiceListBox.Items.Count > 0) { SelectedInvoiceIndex = InvoiceListBox.Items.Count - 1; }
            else
            {
                SelectedInvoiceIndex = -1; 
            }
        }
    }
}
