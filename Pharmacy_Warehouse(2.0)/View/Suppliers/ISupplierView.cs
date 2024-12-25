using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseClient.View.Suppliers
{
    public interface ISupplierView
    {
        IList<string> SupplierList { get; set; }
        int SelectedSupplier { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
        string BankName { get; set; }
        string AccountNumber { get; set; }
        string TaxID { get; set; }
        Presenter.SuplierPresenter Presenter { set; }
    }
}
