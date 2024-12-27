using Pharmacy_Warehouse;
using System.Collections.Generic;


namespace Pharmacy_Warehouse_2._0_.Model.Orders
{
    public interface IInvoiceRepository
    {
        IEnumerable<Invoice> GetAllInvoices();
        Invoice GetInvoiceById(int id);
        void AddInvoice(Invoice invoice);
        void UpdateInvoice(int id, Invoice updatedInvoice);
        void DeleteInvoice(int id);
    }

}
