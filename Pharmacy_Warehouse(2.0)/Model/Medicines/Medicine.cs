using System;

namespace Pharmacy_Warehouse
{
    public class Medicine
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string RegNumber { get; set; }
        public Manufacturer Producer { get; set; }
        public Packaging PackagingInfo { get; set; }

        public Medicine() { }

        public Medicine(string name, string category, DateTime manufactureDate,
                        DateTime expirationDate, string regNumber, Manufacturer producer, Packaging packaging)
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
            
        }

      
    }

}
