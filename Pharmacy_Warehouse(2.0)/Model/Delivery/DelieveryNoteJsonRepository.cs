using Pharmacy_Warehouse;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse_2._0_.Model.Delivery
{
    public class DeliveryNoteJsonRepository : IDeliveryNoteRepository
    {
        public readonly string JsonPath;
        public List<DeliveryNote> DeliveryNotes;

        public DeliveryNoteJsonRepository(string filename)
        {
            JsonPath = Path.Combine(Path.GetTempPath(), filename);
            if (!File.Exists(JsonPath))
            {
                CreateDeliveryNotesJsonStub();
            }
            LoadDeliveryNotesFromFile();
        }

        public void CreateDeliveryNotesJsonStub()
        {
            List<DeliveryNote> deliveryNotes = new List<DeliveryNote>();

            Medicine aspirin = new Medicine(
                name: "Аспирин",
                category: "Противовоспалительные",
                manufactureDate: new DateTime(2023, 1, 10),
                expirationDate: new DateTime(2025, 1, 10),
                regNumber: "RU-456789",
                producer: new Manufacturer("Фармкомпания", "г. Москва", "+7 495 123-45-67"),
                packaging: new Packaging("Коробка", "Картон", 30)
            );

            
            DeliveryNote note1 = new DeliveryNote(
                id: "DN-001",
                date: new DateTime(2023, 1, 10),
                supplier: new Supplier("Поставщик 1", "г. Москва, ул. Складская, д. 1", "+7 495 111-22-33"),
                item: new DeliveryItem(aspirin, pricePerUnit: 50.00m, quantity: 30)
            );

            deliveryNotes.Add(note1);

            
            Medicine paracetamol = new Medicine(
                name: "Парацетамол",
                category: "Обезболивающие",
                manufactureDate: new DateTime(2023, 1, 15),
                expirationDate: new DateTime(2025, 1, 15),
                regNumber: "RU-123456",
                producer: new Manufacturer("Фармкомпания 2", "г. Санкт-Петербург", "+7 812 555-12-34"),
                packaging: new Packaging("Блистер", "Пластик", 10)
            );

            
            DeliveryNote note2 = new DeliveryNote(
                id: "DN-002",
                date: new DateTime(2023, 2, 15),
                supplier: new Supplier("Поставщик 2", "г. Санкт-Петербург, ул. Складская, д. 2", "+7 812 444-55-66"),
                item: new DeliveryItem(paracetamol, pricePerUnit: 25.00m, quantity: 20)
            );

            deliveryNotes.Add(note2);

            SaveDeliveryNoteList(deliveryNotes);
        }

        public void SaveDeliveryNoteList(List<DeliveryNote> deliveryNotes)
        {
            var jsonString = JsonSerializer.Serialize(deliveryNotes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(JsonPath, jsonString);
        }

        public void LoadDeliveryNotesFromFile()
        {
            var jsonString = File.ReadAllText(JsonPath);
            DeliveryNotes = JsonSerializer.Deserialize<List<DeliveryNote>>(jsonString);
        }

        public IEnumerable<DeliveryNote> GetAllDeliveryNotes()
        {
            return DeliveryNotes;
        }

        public DeliveryNote GetDeliveryNoteById(int id)
        {
            return DeliveryNotes[id];
        }

        public void AddDeliveryNote(DeliveryNote deliveryNote)
        {
            DeliveryNotes.Add(deliveryNote);
            SaveDeliveryNoteList(DeliveryNotes);
        }

        public void UpdateDeliveryNote(int id, DeliveryNote updatedDeliveryNote)
        {
            
            if (id >= 0)
            {
                DeliveryNotes[id] = updatedDeliveryNote;
                SaveDeliveryNoteList(DeliveryNotes);
            }
            else
            {
                throw new ArgumentException("Накладная с указанным ID не найдена.");
            }
        }

        public void DeleteDeliveryNote(int id)
        {
            var note = DeliveryNotes[id];
            if (note != null)
            {
                DeliveryNotes.Remove(note);
                SaveDeliveryNoteList(DeliveryNotes);
            }
            else
            {
                throw new ArgumentException("Накладная с указанным ID не найдена.");
            }
        }

        public void SaveDelieveryNote(int id, DeliveryNote delieveryNote)
        {
            DeliveryNotes[id] = delieveryNote;
            SaveDeliveryNoteList(DeliveryNotes);
        }
    }


}