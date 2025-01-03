﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse
{
    public class DeliveryItem
    {
        public Medicine Medicine { get; private set; }
        public decimal PricePerUnit { get; private set; }
        public int Quantity { get; private set; }

        public DeliveryItem(Medicine medicine, decimal pricePerUnit, int quantity)
        {
            if (medicine == null)
                throw new ArgumentNullException(nameof(medicine));
            if (pricePerUnit <= 0)
                throw new ArgumentException("Цена за единицу должна быть больше нуля.");
            if (quantity <= 0)
                throw new ArgumentException("Количество должно быть больше нуля.");

            Medicine = medicine;
            PricePerUnit = pricePerUnit;
            Quantity = quantity;
        }

        public decimal TotalPrice
        {
            get
            {
                return PricePerUnit * Quantity;
            }
        }

        public override string ToString()
        {
            return $"{Medicine.Name}, Цена: {PricePerUnit:C}, Кол-во: {Quantity}, Всего: {TotalPrice:C}";
        }
    }
}
