using Pharmacy_Warehouse.Model.Suppliers;
using Pharmacy_Warehouse;
using Pharmacy_Warehouse_2._0_.Model.Medicines;
using Pharmacy_Warehouse_2._0_.View.MedicinesView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseClient.View.Suppliers;

namespace Pharmacy_Warehouse_2._0_.Presenter
{
    public class MedicinePresenter
    {
        private readonly IMedicineRepository _medicineRepository;
        private readonly IMedicineView _medicineView;

        public MedicinePresenter(IMedicineView medicineView, IMedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
            _medicineView = medicineView;
            medicineView.Presenter = this;

            _medicineView.LoadMainForm += OnLoadMainForm;

            UpdateMedicineListView();
        }

        private void OnLoadMainForm(object sender, EventArgs e)
        {
            _medicineView.Hide();
        }

        private void UpdateMedicineListView()
        {
            var medicinesName = from medicine in _medicineRepository.GetAllMedicines() select medicine.Name;
            int SelectedMedicine = _medicineView.SelectedMedicine >= 0 ? _medicineView.SelectedMedicine : 0;
            _medicineView.MedicineList = medicinesName.ToList();
            _medicineView.SelectedMedicine = SelectedMedicine;
        }

        public void UpdateMedicineView(int p)
        {
            Medicine medicine = _medicineRepository.GetMedicine(p);
            _medicineView.Name = medicine.Name;
            _medicineView.Category = medicine.Category;
            _medicineView.ManufactureDate = medicine.ManufactureDate;
            _medicineView.ExpirationDate = medicine.ExpirationDate;
            _medicineView.RegNumber = medicine.RegNumber;
            _medicineView.SetManufactureData(medicine.Producer);
            
            _medicineView.SetPackingInfo(medicine.PackagingInfo);
            
            
        }
        public void AddSupplier()
        {
            Medicine medicine = new Medicine();
            _medicineRepository.AddMedicine(medicine);
            UpdateMedicineListView();
        }

        public void SaveMedicine()
        {
            Medicine medicine = new Medicine(_medicineView.Name, _medicineView.Category, _medicineView.ManufactureDate,
                _medicineView.ExpirationDate, _medicineView.RegNumber, _medicineView.GetManufactureData(), _medicineView.GetPackagingInfo() );
            _medicineRepository.SaveMedicine(_medicineView.SelectedMedicine, medicine);
            UpdateMedicineListView();
        }
    }
}
