using Pharmacy_Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse_2._0_.View.InvoiceView
{
    public interface IInvoiceView
    {
        event EventHandler LoadMainForm;
        IList<string> InvoiceList { get; set; }
        int SelectedInvoiceIndex { get; set; }
        string Id { get; set; }
        DateTime Date { get; set; }
        /*Customer Customer { get; set; }*/
        string SellerName { get; set; }
        DeliveryItem DeliveryItem { get; set; }
        int TotalCost {  get; set; }
        int Quantity {  get; set; }
        decimal PricePerUnit {  get; set; }
        string CustomerName { get; set; }
        string MedicineName {  get; set; }
        void Show();
        void Hide();
        Presenter.InvoicePresenter Presenter { get; set; }
    }

}
