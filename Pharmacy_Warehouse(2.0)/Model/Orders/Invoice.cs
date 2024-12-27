using System;

namespace Pharmacy_Warehouse
{
    public class Invoice
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public string SellerName { get; set; }
        public DeliveryItem DeliveryItem { get; set; }

        public Invoice(string id, DateTime date, Customer customer, string sellerName, DeliveryItem deliveryItem)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Номер счета не может быть пустым.");
            if (date > DateTime.Now)
                throw new ArgumentException("Дата счета не может быть в будущем.");
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));
            if (string.IsNullOrWhiteSpace(sellerName))
                throw new ArgumentException("Фамилия продавца не может быть пустой.");
            if(deliveryItem == null)
                throw new ArgumentNullException(nameof(deliveryItem));
            Id = id;
            Date = date;
            Customer = customer;
            SellerName = sellerName;
            DeliveryItem = deliveryItem;
        }

    }
}
