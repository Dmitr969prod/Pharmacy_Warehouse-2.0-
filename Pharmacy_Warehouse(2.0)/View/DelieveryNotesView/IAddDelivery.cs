using Pharmacy_Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
