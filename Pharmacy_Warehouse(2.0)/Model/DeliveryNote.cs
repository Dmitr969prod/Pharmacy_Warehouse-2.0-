using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse
{
    using System;
    using System.Collections.Generic;



    public class DeliveryNote
    {
        public string Id { get; private set; }
        public DateTime Date { get; private set; }
        private List<DeliveryItem> items = new List<DeliveryItem>();

        public DeliveryNote(string id, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Номер накладной не может быть пустым.");
            if (date > DateTime.Now)
                throw new ArgumentException("Дата поступления не может быть в будущем.");

            Id = id;
            Date = date;
        }

        public void AddItem(DeliveryItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            items.Add(item);
        }

        public IReadOnlyList<DeliveryItem> GetItems()
        {
            return items.AsReadOnly();
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
            return $"Накладная №{Id}, Дата: {Date.ToShortDateString()}, Всего позиций: {items.Count}, Общая сумма: {TotalCost:C}";
        }
    }

}
