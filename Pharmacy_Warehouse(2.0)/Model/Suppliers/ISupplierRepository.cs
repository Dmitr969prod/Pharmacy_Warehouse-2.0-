using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
