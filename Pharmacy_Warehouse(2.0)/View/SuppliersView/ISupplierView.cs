using System;
using System.Collections.Generic;

namespace WarehouseClient.View.Suppliers
{
    public interface ISupplierView
    {
        event EventHandler LoadMainForm;
        IList<string> SupplierList { get; set; }
        int SelectedSupplier { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
        string BankName { get; set; }
        string AccountNumber { get; set; }
        string TaxID { get; set; }
        void Show();
        void Hide();
        Presenter.SuplierPresenter Presenter { set; }
    }
}
