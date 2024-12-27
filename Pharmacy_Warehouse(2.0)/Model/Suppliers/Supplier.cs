using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        
        public void UpdateContactInfo(string newAddress, string newPhone)
        {
            if (string.IsNullOrWhiteSpace(newAddress))
                throw new ArgumentException("Адрес не может быть пустым.");
            if (string.IsNullOrWhiteSpace(newPhone))
                throw new ArgumentException("Телефон не может быть пустым.");

            Address = newAddress;
            Phone = newPhone;
        }

        
        public void UpdateBankInfo(string newBankName, string newAccountNumber)
        {
            if (string.IsNullOrWhiteSpace(newBankName))
                throw new ArgumentException("Название банка не может быть пустым.");
            if (string.IsNullOrWhiteSpace(newAccountNumber))
                throw new ArgumentException("Номер расчетного счета не может быть пустым.");

            BankName = newBankName;
            AccountNumber = newAccountNumber;
        }

        
        public List<Medicine> GetSuppliedMedicines()
        {
            return new List<Medicine>(suppliedMedicines);
        }

        
        public void AddMedicine(Medicine medicine)
        {
            if (medicine == null)
                throw new ArgumentNullException(nameof(medicine));

            if (!suppliedMedicines.Contains(medicine))
                suppliedMedicines.Add(medicine);
        }

       
        public void RemoveMedicine(Medicine medicine)
        {
            if (medicine == null)
                throw new ArgumentNullException(nameof(medicine));

            suppliedMedicines.Remove(medicine);
        }

        public override string ToString()
        {
            return $"{Name}, Адрес: {Address}, Телефон: {Phone}, Банк: {BankName}, Счет: {AccountNumber}, ИНН: {TaxId}";
        }
    }

}
