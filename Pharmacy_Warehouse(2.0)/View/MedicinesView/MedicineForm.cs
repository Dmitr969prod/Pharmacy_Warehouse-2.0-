using Pharmacy_Warehouse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Warehouse_2._0_.View.MedicinesView
{
    public partial class MedicineForm : Form, IMedicineView
    {
        public event EventHandler LoadMainForm;
        private bool _isEditMode = false;
        public MedicineForm()
        {
            InitializeComponent();
        }

        public IList<string> MedicineList
        {
            get { return (IList<string>)this.MedicinesListBox.DataSource; }
            set { this.MedicinesListBox.DataSource = value; }
        }

        public int SelectedMedicine
        {
            get { return this.MedicinesListBox.SelectedIndex; }
            set { this.MedicinesListBox.SelectedIndex = value; }
        }
        public string Name
        {
            get { return this.NameMedicineBox.Text; }
            set { this.NameMedicineBox.Text = value; }
        }

        public string Category
        {
            get { return this.CategoryMedicineBox.Text; }
            set { this.CategoryMedicineBox.Text = value; }
        }
        public DateTime ManufactureDate
        {
            get { return DateTime.Parse(this.ManufactureDateBox.Text); }
            set { this.ManufactureDateBox.Text = value.ToString(); }
        }

        public DateTime ExpirationDate
        {
            get { return DateTime.Parse(this.ExpirationDateBox.Text); }
            set { this.ExpirationDateBox.Text = value.ToString(); }
        }

        public string RegNumber
        {
            get { return this.RegNumberBox.Text; }
            set { this.RegNumberBox.Text = value; }
        }

        public void SetManufactureData(Manufacturer manufacture)
        {
            this.NameManufactureBox.Text = manufacture.Name;
            this.AddressManufactureBox.Text = manufacture.Address;
            this.PhoneNumberBox.Text = manufacture.ContactInfo;
        }
        
        public Manufacturer GetManufactureData()
        {
            return new Manufacturer(
                name: this.NameManufactureBox.Text,
                address: this.AddressManufactureBox.Text,
                contactInfo: this.PhoneNumberBox.Text
                );
        }

        public void SetPackingInfo(Packaging packaging)
        {
            this.TypeBox.Text = packaging.Type;
            this.MaterialBox.Text = packaging.Material;
            this.QuantityBox.Text = packaging.Quantity.ToString();
        }

        public Packaging GetPackagingInfo()
        {
            return new Packaging(
                type: this.TypeBox.Text,
                material: this.MaterialBox.Text,
                quantity: int.Parse(this.QuantityBox.Text)
                );
        }

       

        public Presenter.MedicinePresenter Presenter
        {
            private get; set;
        } 

        private void MedicinesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.UpdateMedicineView(MedicinesListBox.SelectedIndex);
        }

        private void ComeBackButton_Click(object sender, EventArgs e)
        {
            LoadMainForm?.Invoke(this, EventArgs.Empty);
        }

        private void EditSaveButton_Click(object sender, EventArgs e)
        {
            this.NameManufactureBox.ReadOnly = _isEditMode;
            
            _isEditMode = !_isEditMode;

            this.EditSaveButton.Text = _isEditMode ? "Save" : "Edit";

            if (!_isEditMode)
            {
                Presenter.SaveMedicine();
            }
        }
    }
}
