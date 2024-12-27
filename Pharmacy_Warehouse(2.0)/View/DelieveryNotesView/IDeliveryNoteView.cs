using Pharmacy_Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse_2._0_.View.DelieveryNotesView
{
    public interface IDeliveryNoteView
    {
        event EventHandler LoadMainForm;
        IList<string> IDeliveryList { get; set; }
        int SelectedDeliveryNote { get; set; }
        string id { get; set; }
        DateTime Date {  get; set; }
        Supplier Supplier { get; set; }
        DeliveryItem DeliveryItem { get; set; }

        void Show();
        void Hide();
        Presenter.DeliveryNotePresenter Presenter { get; set; }
    }
}
