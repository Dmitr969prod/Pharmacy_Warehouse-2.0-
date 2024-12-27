using Pharmacy_Warehouse;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Pharmacy_Warehouse_2._0_.Model.Medicines
{
    public class MedicineJsonRepository:IMedicineRepository
    {
        public readonly string JsonPath;
        public List<Medicine> medicines;

        public MedicineJsonRepository(string filename)
        {
            JsonPath = Path.Combine(Path.GetTempPath(), filename);
            if (!File.Exists(JsonPath))
            {
                CreateMedicinesJsonStub();
            }
            LoadMedicinesFromFile();
        }

        public void CreateMedicinesJsonStub()
        {
            var producer1 = new Manufacturer("ООО Фарма", "Россия, Москва, ул. Ленина, 1", "+7 800 555-35-35");
            var producer2 = new Manufacturer("ФармГлобал", "Германия, Берлин, ул. Бранденбург, 20", "+49 30 123456");
            var producer3 = new Manufacturer("Зеленый Лекарь", "Беларусь, Минск, ул. Советская, 5", "+375 17 1234567");

           
            var packaging1 = new Packaging("Блистерная упаковка", "Пластик", 10);
            var packaging2 = new Packaging("Пластиковая бутылка", "Пластик", 100);
            var packaging3 = new Packaging("Стеклянный флакон", "Стекло", 50);

            List<Medicine> Medicines = new List<Medicine>
            {
                new Medicine("Парацетамол", "Обезболивающее", new DateTime(2023, 1, 15), new DateTime(2025, 1, 15), "1234567890", producer1, packaging1),
                new Medicine("Аспирин", "Обезболивающее", new DateTime(2022, 6, 1), new DateTime(2024, 6, 1), "2345678901", producer2, packaging2),
                new Medicine("Ибупрофен", "Противовоспалительное", new DateTime(2023, 3, 20), new DateTime(2025, 3, 20), "3456789012", producer3, packaging3),
                new Medicine("Лоперамид", "Противодиарейное", new DateTime(2023, 7, 10), new DateTime(2025, 7, 10), "4567890123", producer1, packaging1),
                new Medicine("Цитрамон", "Обезболивающее", new DateTime(2022, 10, 5), new DateTime(2024, 10, 5), "5678901234", producer2, packaging2),
                new Medicine("Каламин", "Антисептик", new DateTime(2023, 5, 15), new DateTime(2025, 5, 15), "6789012345", producer3, packaging3),
                new Medicine("Супрастин", "Антигистаминное", new DateTime(2023, 2, 28), new DateTime(2025, 2, 28), "7890123456", producer1, packaging1),
                new Medicine("Тамифлю", "Противовирусное", new DateTime(2023, 4, 10), new DateTime(2025, 4, 10), "8901234567", producer2, packaging2),
                new Medicine("Фервекс", "Простуда", new DateTime(2022, 12, 1), new DateTime(2024, 12, 1), "9012345678", producer3, packaging3),
                new Medicine("Нурофен", "Обезболивающее", new DateTime(2023, 8, 8), new DateTime(2025, 8, 8), "0123456789", producer1, packaging1)
            };

            SaveMedicineList(Medicines);
        }

        public void SaveMedicineList(List<Medicine> medicines)
        {
            var JsonString = JsonSerializer.Serialize(medicines, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(JsonPath, JsonString);
        }
        
        public void LoadMedicinesFromFile() 
        {
            var JsonString = File.ReadAllText(JsonPath);
            medicines = JsonSerializer.Deserialize<List<Medicine>>(JsonString);
        }

        public IEnumerable<Medicine> GetAllMedicines()
        {
            return medicines;
        }

        public Medicine GetMedicine(int Id)
        {
            return medicines[Id];
        }

        public void AddMedicine(Medicine medicine)
        {
            medicines.Add(medicine);
            SaveMedicineList(medicines);
        }

        public void SaveMedicine(int Id,  Medicine medicine) 
        {
            medicines[Id] = medicine;
            SaveMedicineList(medicines);
        }
    
    }
}
