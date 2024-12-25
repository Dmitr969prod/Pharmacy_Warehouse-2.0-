using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse
{
    public class Invoice
    {
        public string Id { get; private set; }
        public DateTime Date { get; private set; }
        public Customer Customer { get; private set; }
        public string SellerName { get; private set; }
        private List<DeliveryItem> items = new List<DeliveryItem>();

        public Invoice(string id, DateTime date, Customer customer, string sellerName)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Номер счета не может быть пустым.");
            if (date > DateTime.Now)
                throw new ArgumentException("Дата счета не может быть в будущем.");
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));
            if (string.IsNullOrWhiteSpace(sellerName))
                throw new ArgumentException("Фамилия продавца не может быть пустой.");

            Id = id;
            Date = date;
            Customer = customer;
            SellerName = sellerName;
        }

        public void AddItem(DeliveryItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            items.Add(item);
        }

        public decimal TotalCost
        {
            get
            {
                return CalculateTotalCost();
            }
        }


        private decimal CalculateTotalCost()
        {
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.TotalPrice;
            }
            return total;
        }

        public override string ToString()
        {
            return $"Счет-фактура №{Id}, Дата: {Date.ToShortDateString()}, Покупатель: {Customer.Name}, Продавец: {SellerName}, Сумма: {TotalCost:C}";
        }
    }
}
