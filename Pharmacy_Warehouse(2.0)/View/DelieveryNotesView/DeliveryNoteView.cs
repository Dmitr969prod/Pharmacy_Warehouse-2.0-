using Pharmacy_Warehouse;
using Pharmacy_Warehouse_2._0_.View.DelieveryNotesView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Warehouse_2._0_.View.DelieveryNoteView
{
    public partial class DeliveryNoteView : Form, IDeliveryNoteView
    {
        private bool _isEditMode = false;

        public event EventHandler LoadMainForm;

        public DeliveryNoteView()
        {
            InitializeComponent();
        }

        public IList<string> IDeliveryList
        {
            get { return (IList<string>)this.DeliveryNotesListBox.DataSource; }
            set { this.DeliveryNotesListBox.DataSource = value; }
        }

        public int SelectedDeliveryNote
        {
            get { return this.DeliveryNotesListBox.SelectedIndex; }
            set { this.DeliveryNotesListBox.SelectedIndex = value; }
        }

        public string id
        {
            get { return this.IdTextBox.Text; }
            set { this.IdTextBox.Text = value; }
        }

        public DateTime Date
        {
            get { return this.dateTimePicker1.Value; }
            set { this.dateTimePicker1.Value = value; }
        }

        public Supplier Supplier
        {
            get
            {
                return new Supplier(
                    name: this.SupplierNameBox.Text,
                    address: null, // Адрес не нужен в форме.
                    phone: null // Телефон не нужен в форме.
                );
            }
            set
            {
                this.SupplierNameBox.Text = value?.Name ?? string.Empty;
            }
        }

        public DeliveryItem DeliveryItem
        {
            get
            {
                return new DeliveryItem(
                    new Medicine(
                        name: this.MedicineNameBox.Text,
                        category: null, // Категория не нужна в форме.
                        manufactureDate: DateTime.MinValue, // Даты не нужны в форме.
                        expirationDate: DateTime.MinValue,
                        regNumber: null,
                        producer: null,
                        packaging: null
                    ),
                    pricePerUnit: decimal.Parse(this.dd.Text),
                    quantity: int.Parse(this.QuantityBox.Text)
                );
            }
            set
            {
                if (value != null)
                {
                    this.MedicineNameBox.Text = value.Medicine.Name;
                    this.PricePerUnitBox.Text = value.PricePerUnit.ToString();
                    this.QuantityBox.Text = value.Quantity.ToString();
                }
                else
                {
                    this.MedicineNameBox.Text = string.Empty;
                    this.PricePerUnitBox.Text = "0";
                    this.QuantityBox.Text = "0";
                }
            }
        }


        public Presenter.DeliveryNotePresenter Presenter {  get; set; }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Presenter.AddDeliveryNote();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            /*Presenter.DeleteDeliveryNote();*/
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComeBackButton_Click_1(object sender, EventArgs e)
        {
            LoadMainForm?.Invoke(this, EventArgs.Empty);
        }

        private void DeliveryNotesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (DeliveryNotesListBox.SelectedIndex >= 0)
            {
                Presenter.UpdateDeliveryNoteView(DeliveryNotesListBox.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           AddDelievery addDelievery = new AddDelievery();
            addDelievery.Show();
        }
    }

}
