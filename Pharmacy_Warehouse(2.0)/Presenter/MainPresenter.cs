using Pharmacy_Warehouse_2._0_.View.DelieveryNotesView;
using Pharmacy_Warehouse_2._0_.View.InvoiceView;
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
        private readonly IInvoiceView _invoiceView;

        public MainPresenter(IMainView view, ISupplierView supplierView, IMedicineView medicineView, IDeliveryNoteView deliveryNoteView, IInvoiceView invoiceView)
        {
            _view = view;
            _supplierView = supplierView;
            _medicineView = medicineView;
            _deliveryNoteView = deliveryNoteView;
            _invoiceView = invoiceView;

            _view.LoadDeliveryNoteForm += OnLoadDeliveryNoteView;
            _view.LoadMedicineForm += OnLoadMedicineView;
            _view.LoadSupplierForm += OnLoadSupplierView;
            _view.LoadInvoiceForm += OnLoadInvoiceView;
        }
        private void OnLoadInvoiceView(object sender, EventArgs e)
        {
            _invoiceView.Show();
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
