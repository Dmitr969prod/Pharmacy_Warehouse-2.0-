using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Warehouse.Model.Suppliers;
using Pharmacy_Warehouse_2._0_.Model.Delivery;
using Pharmacy_Warehouse_2._0_.Model.Medicines;
using Pharmacy_Warehouse_2._0_.Model.Orders;
using Pharmacy_Warehouse_2._0_.Presenter;
using Pharmacy_Warehouse_2._0_.View.DelieveryNoteView;
using Pharmacy_Warehouse_2._0_.View.InvoiceView;
using Pharmacy_Warehouse_2._0_.View.MedicinesView;
using Pharmacy_Warehouse_2._0_.View.Suppliers;
using WarehouseClient.Presenter;

namespace Pharmacy_Warehouse_2._0_
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new MainForm();
            var viewSupplier = new SupplierForm();
            var viewMedicine = new MedicineForm();
            var viewDeliveryNote = new DeliveryNoteView();
            var viewInvoice = new InvoiceView();
            var viewInvoiceAdd = new InvoiceAdd();
            var MedicineRepository = new MedicineJsonRepository("medicine.json");
            var SupplierRepository = new SupplierJsonRepository("supplier.json");
            var DeliveryNoteRepository = new DeliveryNoteJsonRepository("delivery.json");
            var InvoiceJsonRepository = new InvoiceJsonRepository("invoice.json");

            var invoicePresenter = new InvoicePresenter(viewInvoice, InvoiceJsonRepository, viewInvoiceAdd);
            var MainPresenter = new MainPresenter(view, viewSupplier, viewMedicine, viewDeliveryNote, viewInvoice);
            var presenter = new SuplierPresenter(viewSupplier, SupplierRepository);
            var DeliveryNotePresenter = new DeliveryNotePresenter(viewDeliveryNote, DeliveryNoteRepository);
            var medicinePresenter = new MedicinePresenter(viewMedicine, MedicineRepository);
            
            Application.Run(view);
        }
    }
}
