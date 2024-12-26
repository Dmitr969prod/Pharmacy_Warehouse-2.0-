using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse.Model.Suppliers
{
    public class SupplierJsonRepository:ISupplierRepository
    {
        public readonly string JsonPath;
        public List<Supplier> suppliers;

        public SupplierJsonRepository(string filename)
        {
            Console.WriteLine(Path.GetTempPath());
            JsonPath = Path.Combine(Path.GetTempPath(), filename);
            if(!File.Exists(JsonPath))
            {
                CreateSupplierJsonStub();
            }
            LoadSuppliersFromFile();
        }

        public void CreateSupplierJsonStub()
        {
            var Suppliers = new List<Supplier>()
            {
                new Supplier(
                name: "Поставщик 1",
                address: "г. Москва, ул. Ленина, д. 1",
                phone: "+7 (495) 123-45-67",
                bankName: "Сбербанк",
                accountNumber: "1234567890123456",
                taxId: "7701234567"
            ),
            new Supplier(
                name: "Поставщик 2",
                address: "г. Санкт-Петербург, Невский проспект, д. 15",
                phone: "+7 (812) 987-65-43",
                bankName: "ВТБ",
                accountNumber: "9876543210987654",
                taxId: "7801234567"
            ),
            new Supplier(
                name: "Поставщик 3",
                address: "г. Екатеринбург, ул. Сибирский тракт, д. 20",
                phone: "+7 (343) 456-78-90",
                bankName: "Альфа-Банк",
                accountNumber: "4567890123456789",
                taxId: "6601234567"
            )
            };
            SaveSupplierList(Suppliers);
        }

        public void SaveSupplierList(List<Supplier> suppliers)
        {
            var JsonString = JsonSerializer.Serialize(suppliers);
            File.WriteAllText(JsonPath, JsonString);
        }
        public void LoadSuppliersFromFile()
        {
            var JsonString = File.ReadAllText(JsonPath);
            suppliers = JsonSerializer.Deserialize<List<Supplier>>(JsonString);
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return suppliers;
        }

        public Supplier GetSupplier(int Id)
        {
            return suppliers[Id];
        }

        public void AddSupplier(Supplier supplier)
        {
            suppliers.Add(supplier);
            SaveSupplierList(suppliers);
        }

        public void SaveSupplier(int Id, Supplier supplier)
        {
            suppliers[Id] = supplier;
            SaveSupplierList(suppliers);
        }
    }
}
