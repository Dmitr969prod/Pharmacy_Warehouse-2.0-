using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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
            List<Supplier> Suppliers = new List<Supplier>
            {
                new Supplier("ООО ПоставкиМед", "Россия, Москва, ул. Маяковского, 10", "+7 495 111-22-33", "Сбербанк", "40817810000100000001", "7721234567"),
                new Supplier("МедПартнер", "Россия, Санкт-Петербург, ул. Лермонтова, 3", "+7 812 234-56-78", "Тинькофф", "40802810101010101010", "7845109876"),
                new Supplier("ФармаГлобал", "Россия, Казань, ул. Победы, 25", "+7 843 345-67-89", "ВТБ", "40702810501050505050", "7753001234"),
                new Supplier("Зеленый Лекарь", "Беларусь, Минск, ул. Советская, 15", "+375 17 1234567", "Беларусбанк", "BY40BLBB30120000561961140000", "192234567890"),
                new Supplier("Аптека Север", "Россия, Екатеринбург, ул. Репина, 5", "+7 343 987-65-43", "Сбербанк", "40817810203040506070", "6612345678"),
                new Supplier("ТехноФарм", "Россия, Новосибирск, ул. Красный проспект, 4", "+7 383 123-45-67", "Росбанк", "40601810888800012345", "5423027654"),
                new Supplier("ФармЭксперт", "Россия, Нижний Новгород, ул. Гоголя, 9", "+7 831 777-88-99", "Тинькофф", "40817810567890123456", "5222334455"),
                new Supplier("МедТорг", "Россия, Ростов-на-Дону, ул. Ворошилова, 11", "+7 863 123-45-67", "Сбербанк", "40817810000110000011", "6123456789"),
                new Supplier("Аптека Протек", "Россия, Красноярск, ул. Ленина, 8", "+7 391 123-45-67", "ВТБ", "40702810607080909090", "7734567890"),
                new Supplier("МедСнаб", "Казахстан, Алматы, ул. Абая, 50", "+7 727 123-45-67", "Halyk Bank", "KZ1234001234567890", "1856349208")
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
