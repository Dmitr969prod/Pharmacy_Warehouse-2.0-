using System;
using System.Collections.Generic;

namespace Pharmacy_Warehouse
{


    public class Supplier
    {
        
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string TaxId { get; set; }

        
        private List<Medicine> suppliedMedicines = new List<Medicine>();

        public Supplier(string name=".", string address=".", string phone = ".", string bankName = ".", string accountNumber = ".", string taxId=".")
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название поставщика не может быть пустым.");
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Адрес поставщика не может быть пустым.");
            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Телефон поставщика не может быть пустым.");
            if (string.IsNullOrWhiteSpace(bankName))
                throw new ArgumentException("Название банка не может быть пустым.");
            if (string.IsNullOrWhiteSpace(accountNumber))
                throw new ArgumentException("Номер расчетного счета не может быть пустым.");
            if (string.IsNullOrWhiteSpace(taxId))
                throw new ArgumentException("ИНН не может быть пустым.");

            Name = name;
            Address = address;
            Phone = phone;
            BankName = bankName;
            AccountNumber = accountNumber;
            TaxId = taxId;
        }

        
    }

}
