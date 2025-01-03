﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse
{
    public class Packaging
    {
        public string Type { get; private set; }      
        public string Material { get; private set; }  
        public int Quantity { get; private set; }     

        public Packaging(string type, string material, int quantity)
        {
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentException("Тип упаковки не может быть пустым.");
            if (string.IsNullOrWhiteSpace(material)) throw new ArgumentException("Материал упаковки не может быть пустым.");
            if (quantity <= 0) throw new ArgumentException("Количество должно быть больше нуля.");

            Type = type;
            Material = material;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Type} из {Material}, {Quantity} шт.";
        }
    }

}
