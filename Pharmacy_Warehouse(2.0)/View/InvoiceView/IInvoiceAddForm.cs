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

        string Id { get; }
        /*Customer Customer { get; }
        Medicine Medicine { get; }*/
        decimal PricePerUnit { get; }
        int Quantity { get; }
        string SellerName { get; }
        DateTime date { get; }
        Presenter.InvoicePresenter presenter { get; set; }
    }
}
