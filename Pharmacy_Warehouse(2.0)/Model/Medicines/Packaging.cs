using System;

namespace Pharmacy_Warehouse
{
    public class Packaging
    {
        public string Type { get; set; }      
        public string Material { get; set; }  
        public int Quantity { get; set; }     

        public Packaging() { }

        public Packaging(string type, string material, int quantity)
        {
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentException("Тип упаковки не может быть пустым.");
            if (string.IsNullOrWhiteSpace(material)) throw new ArgumentException("Материал упаковки не может быть пустым.");
            if (quantity <= 0) throw new ArgumentException("Количество должно быть больше нуля.");

            Type = type;
            Material = material;
            Quantity = quantity;
        }

    }

}
