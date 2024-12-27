using Pharmacy_Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse_2._0_.View.InvoiceView
{
    public interface IInvoiceAddForm
    {

        string Id { get; set; }
        Customer Customer { get; set; }
        Medicine Medicine { get; set; }
        decimal PricePerUnit { get; set; }
        int Quantity { get; set; }
        string SellerName { get; set; }
        DateTime date { get; set; }
        Presenter.InvoicePresenter presenter { set; }
    }
}
