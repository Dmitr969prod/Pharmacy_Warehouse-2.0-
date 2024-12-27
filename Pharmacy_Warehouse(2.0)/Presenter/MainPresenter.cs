using Pharmacy_Warehouse_2._0_.View.DelieveryNotesView;
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
        private readonly IDeliveryNoteView _deliveryNoteView;

        public MainPresenter(IMainView view, ISupplierView supplierView, IMedicineView medicineView, IDeliveryNoteView deliveryNoteView)
        {
            _view = view;
            _supplierView = supplierView;
            _medicineView = medicineView;
            _deliveryNoteView = deliveryNoteView;

            _view.LoadDeliveryNoteForm += OnLoadDeliveryNoteView;
            _view.LoadMedicineForm += OnLoadMedicineView;
            _view.LoadSupplierForm += OnLoadSupplierView;
        }
        private void OnLoadDeliveryNoteView(object sender, EventArgs e)
        {
            _deliveryNoteView.Show();
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
