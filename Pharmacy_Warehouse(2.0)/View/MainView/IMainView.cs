using System;

namespace Pharmacy_Warehouse_2._0_
{
    public interface IMainView
    {
        event EventHandler LoadSupplierForm;
        event EventHandler LoadMedicineForm;
        event EventHandler LoadDeliveryNoteForm;
        event EventHandler LoadInvoiceForm;
        void Hide();
        void Show();
    }
}
