﻿using Pharmacy_Warehouse;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse_2._0_.Model.Orders
{
    public class InvoiceJsonRepository:IInvoiceRepository
    {
        public readonly string JsonPath;
        public List<Invoice> Invoices;

        public InvoiceJsonRepository(string filename)
        {
            JsonPath = Path.Combine(Path.GetTempPath(), filename);
            if (!File.Exists(JsonPath))
            {
                CreateInvoicesJsonStub();
            }
            LoadInvoicesFromFile();
        }

        public void CreateInvoicesJsonStub()
        {
            List<Invoice> invoices = new List<Invoice>();

            // Пример клиентов
            Customer customer1 = new Customer(
                name: "ООО Здоровье",
                address: "г. Москва, ул. Лечебная, д. 1",
                phone: "+7 495 123-45-67",
                taxId: "7701234567"
            );

            Customer customer2 = new Customer(
                name: "АО ФармТрейд",
                address: "г. Санкт-Петербург, ул. Медицинская, д. 2",
                phone: "+7 812 555-12-34",
                taxId: "7807654321"
            );

            // Пример товаров
            Medicine aspirin = new Medicine(
                name: "Аспирин",
                category: "Противовоспалительные",
                manufactureDate: new DateTime(2023, 1, 10),
                expirationDate: new DateTime(2025, 1, 10),
                regNumber: "RU-456789",
                producer: new Manufacturer("Фармкомпания", "г. Москва", "+7 495 123-45-67"),
                packaging: new Packaging("Коробка", "Картон", 30)
            );

            DeliveryItem item1 = new DeliveryItem(aspirin, pricePerUnit: 50.00m, quantity: 10);

            Medicine ibuprofen = new Medicine(
                name: "Ибупрофен",
                category: "Обезболивающие",
                manufactureDate: new DateTime(2022, 5, 1),
                expirationDate: new DateTime(2024, 5, 1),
                regNumber: "RU-987654",
                producer: new Manufacturer("Фармкомпания 2", "г. Санкт-Петербург", "+7 812 555-12-34"),
                packaging: new Packaging("Блистер", "Пластик", 20)
            );

            DeliveryItem item2 = new DeliveryItem(ibuprofen, pricePerUnit: 30.00m, quantity: 15);

            // Пример счетов
            Invoice invoice1 = new Invoice(
                id: "INV-001",
                date: DateTime.Now,
                customer: customer1,
                sellerName: "Иванов Иван",
                deliveryItem: item1
            );

            Invoice invoice2 = new Invoice(
                id: "INV-002",
                date: DateTime.Now.AddDays(-1),
                customer: customer2,
                sellerName: "Петров Петр",
                deliveryItem: item2
            );

            invoices.Add(invoice1);
            invoices.Add(invoice2);

            SaveInvoiceList(invoices);
        }

        public void SaveInvoiceList(List<Invoice> invoices)
        {
            var jsonString = JsonSerializer.Serialize(invoices, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(JsonPath, jsonString);
        }

        public void LoadInvoicesFromFile()
        {
            var jsonString = File.ReadAllText(JsonPath);
            Invoices = JsonSerializer.Deserialize<List<Invoice>>(jsonString);
        }

        public IEnumerable<Invoice> GetAllInvoices()
        {
            return Invoices;
        }

        public Invoice GetInvoiceById(int id)
        {
            return Invoices[id];
        }

        public void AddInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
            SaveInvoiceList(Invoices);
        }

        public void UpdateInvoice(int id, Invoice updatedInvoice)
        {
            
            if (id >= 0)
            {
                Invoices[id] = updatedInvoice;
                SaveInvoiceList(Invoices);
            }
            else
            {
                throw new ArgumentException("Счет-фактура с указанным ID не найдена.");
            }
        }

        public void DeleteInvoice(int id)
        {
            var invoice = Invoices[id];
            if (invoice != null)
            {
                Invoices.Remove(invoice);
                SaveInvoiceList(Invoices);
            }
            else
            {
                throw new ArgumentException("Счет-фактура с указанным ID не найдена.");
            }
        }
    }
}