using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Warehouse_2._0_
{
    public partial class MainForm : Form, IMainView
    {
        public event EventHandler LoadSupplierForm;
        public event EventHandler LoadMedicineForm;
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
    }
}
