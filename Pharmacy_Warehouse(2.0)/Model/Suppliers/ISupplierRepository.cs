using System.Collections.Generic;

namespace Pharmacy_Warehouse.Model.Suppliers
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetAllSuppliers();
        Supplier GetSupplier(int Id);
        void AddSupplier(Supplier supplier);
        void SaveSupplier(int Id, Supplier supplier);
    }
}
