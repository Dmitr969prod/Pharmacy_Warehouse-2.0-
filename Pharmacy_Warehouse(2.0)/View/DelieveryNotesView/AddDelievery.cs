using Pharmacy_Warehouse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Warehouse_2._0_.View.DelieveryNotesView
{
    public partial class AddDelievery : Form
    {
        public AddDelievery()
        {
            InitializeComponent();
            List<Supplier> suppliers = new List<Supplier>
            {
                new Supplier("ООО Аптечная сеть", "ул. Ленина, 15", "8-800-555-35-35", "Сбербанк", "40817810600000000001", "1234567890"),
                new Supplier("ЗАО Лекарства России", "пр. Победы, 25", "8-800-123-45-67", "ВТБ", "40802810100000000002", "9876543210"),
                new Supplier("ФармаСнаб", "ул. Советская, 45", "8-800-111-22-33", "Газпромбанк", "40802810800000000003", "5678901234")
            };

            List<Medicine> Medicines = new List<Medicine>();

            // Добавление первого лекарства
            Medicine aspirin = new Medicine(
                name: "Аспирин",
                category: "Противовоспалительные",
                manufactureDate: new DateTime(2023, 1, 10),
                expirationDate: new DateTime(2025, 1, 10),
                regNumber: "RU-456789",
                producer: new Manufacturer("Фармкомпания", "г. Москва, ул. Аптечная, д. 1", "+7 495 123-45-67"),
                packaging: new Packaging("Коробка", "Картон", 30)



            );

            Medicines.Add(aspirin);

            // Добавление второго лекарства
            Medicine paracetamol = new Medicine(
                name: "Парацетамол",
                category: "Обезболивающие",
                manufactureDate: new DateTime(2023, 3, 15),
                expirationDate: new DateTime(2025, 3, 15),
                regNumber: "RU-123456",
                producer: new Manufacturer("Фармкомпания 2", "г. Санкт-Петербург, ул. Аптечная, д. 2", "+7 812 555-12-34"),
                packaging: new Packaging("Блистер", "Пластик", 10)

            );
            Medicines.Add(paracetamol);

            // Добавление третьего лекарства
            Medicine ibuprofen = new Medicine(
                name: "Ибупрофен",
                category: "Противовоспалительные",
                manufactureDate: new DateTime(2023, 5, 20),
                expirationDate: new DateTime(2025, 5, 20),
                regNumber: "RU-789101",
                producer: new Manufacturer("Фармкомпания 3", "г. Казань, ул. Аптечная, д. 3", "+7 843 333-22-11"),
                packaging: new Packaging("Флакон", "Пластик", 50)

            );
            Medicines.Add(ibuprofen);

            SuppliersComboBox.DataSource = suppliers;
            SuppliersComboBox.DisplayMember = "Name";

            MedicinesComboBox.DataSource = Medicines;
            MedicinesComboBox.DisplayMember = "Name";
        }

        private void ComeBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
        
        
        private void SuppliersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier selectedSupplier = (Supplier)SuppliersComboBox.SelectedItem;
            
        }

        private void MedicinesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicine selectedMedicine = (Medicine)MedicinesComboBox.SelectedItem;
            
        }
    }
}
