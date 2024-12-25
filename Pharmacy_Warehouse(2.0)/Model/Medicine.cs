using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse
{
    public class Medicine
    {
        public string Name { get; private set; }
        public string Category { get; private set; }
        public DateTime ManufactureDate { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public string RegNumber { get; private set; }
        public Manufacturer Producer { get; private set; }
        public Packaging PackagingInfo { get; private set; }
        public Supplier Supplier { get; private set; }

        public Medicine(string name, string category, DateTime manufactureDate,
                        DateTime expirationDate, string regNumber, Manufacturer producer, Packaging packaging, Supplier supplier)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Category = category ?? throw new ArgumentNullException(nameof(category));
            ManufactureDate = manufactureDate;
            ExpirationDate = expirationDate > manufactureDate
                             ? expirationDate
                             : throw new ArgumentException("Срок годности должен быть позже даты производства.");
            RegNumber = regNumber ?? throw new ArgumentNullException(nameof(regNumber));
            Producer = producer ?? throw new ArgumentNullException(nameof(producer));
            PackagingInfo = packaging ?? throw new ArgumentNullException(nameof(packaging));
            Supplier = supplier;
        }

        public bool IsExpired()
        {
            return DateTime.Now > ExpirationDate;
        }


        public string GetShortInfo()
        {
            return $"{Name} - Срок годности до {ExpirationDate.ToShortDateString()}";
        }



        public int DaysUntilExpiration()
        {
            return (ExpirationDate - DateTime.Now).Days;
        }



        public override string ToString()
        {
            return $"Лекарство: {Name}, Категория: {Category}, Производитель: {Producer}, Упаковка: {PackagingInfo}, " +
                   $"Дата производства: {ManufactureDate.ToShortDateString()}, Срок годности: {ExpirationDate.ToShortDateString()}, " +
                   $"Рег. номер: {RegNumber}";
        }
    }

}
