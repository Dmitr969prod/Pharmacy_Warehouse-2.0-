using Pharmacy_Warehouse_2._0_.View.MedicinesView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseClient.View.Suppliers;

namespace Pharmacy_Warehouse_2._0_.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly ISupplierView _supplierView;
        private readonly IMedicineView _medicineView;

        public MainPresenter(IMainView view, ISupplierView supplierView, IMedicineView medicineView)
        {
            _view = view;
            _supplierView = supplierView;
            _medicineView = medicineView;

            _view.LoadMedicineForm += OnLoadMedicineView;
            _view.LoadSupplierForm += OnLoadSupplierView;
        }

        private void OnLoadSupplierView(object sender, EventArgs e) 
        {
            
            _supplierView.Show();
        }

        private void OnLoadMedicineView(object sender, EventArgs e)
        {
            _medicineView.Show();
        }
    }
}
