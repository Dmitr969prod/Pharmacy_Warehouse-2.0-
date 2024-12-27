using Pharmacy_Warehouse;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
            List<Medicine> Medicines = new List<Medicine>();

            // Добавление первого лекарства
            Medicine aspirin = new Medicine(
                name: "Аспирин",
                category: "Противовоспалительные",
                manufactureDate: new DateTime(2023, 1, 10),
                expirationDate: new DateTime(2025, 1, 10),
                regNumber: "RU-456789",
                producer: new Manufacturer("Фармкомпания", "г. Москва, ул. Аптечная, д. 1", "+7 495 123-45-67"),
                packaging: new Packaging("Коробка", "Картон", 30)
                
                

            ) ;
            
            Medicines.Add(aspirin);

            // Добавление второго лекарства
            Medicine paracetamol = new Medicine(
                name: "Парацетамол",
                category: "Обезболивающие",
                manufactureDate: new DateTime(2023, 3, 15),
                expirationDate: new DateTime(2025, 3, 15),
                regNumber: "RU-123456",
                producer: new Manufacturer("Фармкомпания 2", "г. Санкт-Петербург, ул. Аптечная, д. 2", "+7 812 555-12-34"),
                packaging: new Packaging("Блистер", "Пластик", 10)
                
            );
            Medicines.Add(paracetamol);

            // Добавление третьего лекарства
            Medicine ibuprofen = new Medicine(
                name: "Ибупрофен",
                category: "Противовоспалительные",
                manufactureDate: new DateTime(2023, 5, 20),
                expirationDate: new DateTime(2025, 5, 20),
                regNumber: "RU-789101",
                producer: new Manufacturer("Фармкомпания 3", "г. Казань, ул. Аптечная, д. 3", "+7 843 333-22-11"),
                packaging: new Packaging("Флакон", "Пластик", 50)
                
            );
            Medicines.Add(ibuprofen);

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
