using System;

namespace Pharmacy_Warehouse
{
    public class Manufacturer
    {
        public string Name { get; set; }      
        public string Address { get; set; }   
        public string ContactInfo { get; set; } 

        public Manufacturer() { }

        public Manufacturer(string name, string address, string contactInfo)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Название производителя не может быть пустым.");
            if (string.IsNullOrWhiteSpace(address)) throw new ArgumentException("Адрес производителя не может быть пустым.");
            if (string.IsNullOrWhiteSpace(contactInfo)) throw new ArgumentException("Контактная информация не может быть пустой.");

            Name = name;
            Address = address;
            ContactInfo = contactInfo;
        }

    }

}
