using Pharmacy_Warehouse;
using System;

namespace Pharmacy_Warehouse_2._0_.View.DelieveryNotesView
{
    public interface IAddDelivery
    {
        Supplier supplier { get; set; }
        Medicine medicine { get; set; }
        string Id { get; set; }
        DateTime date { get; set; }
        decimal price { get; set; }
        int count { get; set; }
        Presenter.DeliveryNotePresenter presenter { set; }
    }
}
