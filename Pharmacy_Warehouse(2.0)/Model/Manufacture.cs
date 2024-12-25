using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse
{
    public class Manufacturer
    {
        public string Name { get; private set; }      
        public string Address { get; private set; }   
        public string ContactInfo { get; private set; } 

        public Manufacturer(string name, string address, string contactInfo)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Название производителя не может быть пустым.");
            if (string.IsNullOrWhiteSpace(address)) throw new ArgumentException("Адрес производителя не может быть пустым.");
            if (string.IsNullOrWhiteSpace(contactInfo)) throw new ArgumentException("Контактная информация не может быть пустой.");

            Name = name;
            Address = address;
            ContactInfo = contactInfo;
        }

        public override string ToString()
        {
            return $"{Name}, Адрес: {Address}, Контакты: {ContactInfo}";
        }
    }

}
