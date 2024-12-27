using Pharmacy_Warehouse;
using System.Collections.Generic;

namespace Pharmacy_Warehouse_2._0_.Model.Medicines
{
    public interface IMedicineRepository
    {
        IEnumerable<Medicine> GetAllMedicines();
        Medicine GetMedicine(int id);
        void AddMedicine(Medicine medicine);
        void SaveMedicine(int Id, Medicine medicine);
    }
}
