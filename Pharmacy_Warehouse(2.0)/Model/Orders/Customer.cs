using System;

namespace Pharmacy_Warehouse
{
 
    public class Customer
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string TaxId { get; private set; }

        public Customer(string name, string address, string phone, string taxId)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название покупателя не может быть пустым.");
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Адрес не может быть пустым.");
            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Телефон не может быть пустым.");
            if (string.IsNullOrWhiteSpace(taxId))
                throw new ArgumentException("ИНН не может быть пустым.");

            Name = name;
            Address = address;
            Phone = phone;
            TaxId = taxId;
        }


    }

}
