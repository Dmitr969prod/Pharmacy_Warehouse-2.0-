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

            // Пример поставщиков
            Supplier supplier1 = new Supplier("ООО ПоставкиМед", "Россия, Москва, ул. Маяковского, 10", "+7 495 111-22-33", "Сбербанк", "40817810000100000001", "7721234567");
            Supplier supplier2 = new Supplier("МедПартнер", "Россия, Санкт-Петербург, ул. Лермонтова, 3", "+7 812 234-56-78", "Тинькофф", "40802810101010101010", "7845109876");
            Supplier supplier3 = new Supplier("ФармаГлобал", "Россия, Казань, ул. Победы, 25", "+7 843 345-67-89", "ВТБ", "40702810501050505050", "7753001234");

            // Пример DeliveryItem (из предыдущего списка)
            List<DeliveryItem> deliveryItems = new List<DeliveryItem>
{
            new DeliveryItem(new Medicine("Аспирин", "Противовоспалительные", new DateTime(2023, 1, 10), new DateTime(2025, 1, 10), "RU-456789",
                new Manufacturer("Фармкомпания", "г. Москва", "+7 495 123-45-67"), new Packaging("Коробка", "Картон", 30)), 50.00m, 10),
            new DeliveryItem(new Medicine("Ибупрофен", "Обезболивающие", new DateTime(2022, 5, 1), new DateTime(2024, 5, 1), "RU-987654",
                new Manufacturer("Фармкомпания 2", "г. Санкт-Петербург", "+7 812 555-12-34"), new Packaging("Блистер", "Пластик", 20)), 30.00m, 15),
            // Повторяем для еще 8 элементов
            new DeliveryItem(new Medicine("Аспирин", "Противовоспалительные", new DateTime(2023, 1, 10), new DateTime(2025, 1, 10), "RU-456789",
                new Manufacturer("Фармкомпания", "г. Москва", "+7 495 123-45-67"), new Packaging("Коробка", "Картон", 30)), 45.50m, 8),
            new DeliveryItem(new Medicine("Ибупрофен", "Обезболивающие", new DateTime(2022, 5, 1), new DateTime(2024, 5, 1), "RU-987654",
                new Manufacturer("Фармкомпания 2", "г. Санкт-Петербург", "+7 812 555-12-34"), new Packaging("Блистер", "Пластик", 20)), 32.00m, 12)
        };

            // Генерация DeliveryNote
            Random random = new Random();

            for (int i = 1; i <= 10; i++)
            {
                var supplier = i % 3 == 0 ? supplier3 : i % 2 == 0 ? supplier2 : supplier1;
                var item = deliveryItems[random.Next(deliveryItems.Count)];
                var date = DateTime.Now.AddDays(-random.Next(1, 30)); // Генерация случайной даты в пределах последнего месяца

                DeliveryNote deliveryNote = new DeliveryNote(
                    id: $"DN-{i:D3}",
                    date: date,
                    supplier: supplier,
                    item: item
                );

                deliveryNotes.Add(deliveryNote);
            }


            

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