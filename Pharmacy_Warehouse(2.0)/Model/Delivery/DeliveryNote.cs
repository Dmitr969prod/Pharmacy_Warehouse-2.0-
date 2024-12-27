using System;

namespace Pharmacy_Warehouse
{
    public class DeliveryNote
    {
        public string Id { get; private set; }
        public DateTime Date { get; private set; }
        public Supplier Supplier { get; private set; }
        public DeliveryItem Item { get; private set; }

        public DeliveryNote(string id, DateTime date, Supplier supplier, DeliveryItem item)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Номер накладной не может быть пустым.");
            if (date > DateTime.Now)
                throw new ArgumentException("Дата поступления не может быть в будущем.");
            if (supplier == null)
                throw new ArgumentNullException(nameof(supplier));
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            Id = id;
            Date = date;
            Supplier = supplier;
            Item = item;
        }

        public decimal TotalCost
        {
            get
            {
                return Item.TotalPrice;
            }
        }
    }

}
