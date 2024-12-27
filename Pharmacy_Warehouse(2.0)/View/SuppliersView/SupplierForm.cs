using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WarehouseClient.View.Suppliers;
using WarehouseClient.Presenter;

namespace Pharmacy_Warehouse_2._0_.View.Suppliers
{
    public partial class SupplierForm : Form, ISupplierView
    {
        private bool _isEditMode = false;

        public event EventHandler LoadMainForm;
        public SupplierForm()
        {
            InitializeComponent();
        }

        
        public IList<string> SupplierList
        {
            get { return (IList<string>)this.SuppliersListBox.DataSource; }
            set { this.SuppliersListBox.DataSource = value; }
        }

        public int SelectedSupplier
        {
            get { return this.SuppliersListBox.SelectedIndex; }
            set { this.SuppliersListBox.SelectedIndex = value; }
        }

        public string Name
        {
            get { return this.NameBox.Text; }
            set { this.NameBox.Text = value; }
        }

        public string Address
        {
            get { return this.AddressBox.Text; }
            set { this.AddressBox.Text = value; }
        }

        public string PhoneNumber
        {
            get { return this.PhoneNumberBox.Text; }
            set { this.PhoneNumberBox.Text = value; }
        }
        public string BankName
        {
            get { return this.BankNameBox.Text; }
            set { this.BankNameBox.Text = value; }
        }
        public string AccountNumber
        {
            get { return this.AccountNumberBox.Text; }
            set { this.AccountNumberBox.Text = value; }
        }

        public string TaxID
        {
            get { return this.TaxIdBox.Text; }
            set { this.TaxIdBox.Text = value; }
        }
        public SuplierPresenter Presenter
        {
            private get; set;
        }

        private void SuppliersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.UpdateSupplierView(SuppliersListBox.SelectedIndex);
        }

        private void ComeBackButton_Click(object sender, EventArgs e)
        {
            LoadMainForm?.Invoke(this, EventArgs.Empty);
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
