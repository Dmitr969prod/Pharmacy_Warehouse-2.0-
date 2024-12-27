using System;
using System.Windows.Forms;

namespace Pharmacy_Warehouse_2._0_
{
    public partial class MainForm : Form, IMainView
    {
        public event EventHandler LoadSupplierForm;
        public event EventHandler LoadMedicineForm;
        public event EventHandler LoadDeliveryNoteForm;
        public event EventHandler LoadInvoiceForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void GetSupplierButton_Click(object sender, EventArgs e)
        {
            LoadSupplierForm?.Invoke(this, EventArgs.Empty);
        }

        private void MedicineButton_Click(object sender, EventArgs e)
        {
            LoadMedicineForm?.Invoke(this, EventArgs.Empty);
        }

        private void DeliverButton_Click(object sender, EventArgs e)
        {
            LoadDeliveryNoteForm?.Invoke(this, EventArgs.Empty);
        }

        private void CustomerOrderButton_Click(object sender, EventArgs e)
        {
            LoadInvoiceForm?.Invoke(this, EventArgs.Empty);
        }
    }
}
