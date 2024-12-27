using Pharmacy_Warehouse;
using Pharmacy_Warehouse_2._0_.Presenter;
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
    public partial class AddDelievery : Form, IAddDelivery
    {
        public AddDelievery(DeliveryNotePresenter Presenter)
        {
            InitializeComponent();
            presenter = Presenter; 
            List<Supplier> suppliers = new List<Supplier>
            {
                new Supplier("ООО ПоставкиМед", "Россия, Москва, ул. Маяковского, 10", "+7 495 111-22-33", "Сбербанк", "40817810000100000001", "7721234567"),
                new Supplier("МедПартнер", "Россия, Санкт-Петербург, ул. Лермонтова, 3", "+7 812 234-56-78", "Тинькофф", "40802810101010101010", "7845109876"),
                new Supplier("ФармаГлобал", "Россия, Казань, ул. Победы, 25", "+7 843 345-67-89", "ВТБ", "40702810501050505050", "7753001234"),
                new Supplier("Зеленый Лекарь", "Беларусь, Минск, ул. Советская, 15", "+375 17 1234567", "Беларусбанк", "BY40BLBB30120000561961140000", "192234567890"),
                new Supplier("Аптека Север", "Россия, Екатеринбург, ул. Репина, 5", "+7 343 987-65-43", "Сбербанк", "40817810203040506070", "6612345678"),
                new Supplier("ТехноФарм", "Россия, Новосибирск, ул. Красный проспект, 4", "+7 383 123-45-67", "Росбанк", "40601810888800012345", "5423027654"),
                new Supplier("ФармЭксперт", "Россия, Нижний Новгород, ул. Гоголя, 9", "+7 831 777-88-99", "Тинькофф", "40817810567890123456", "5222334455"),
                new Supplier("МедТорг", "Россия, Ростов-на-Дону, ул. Ворошилова, 11", "+7 863 123-45-67", "Сбербанк", "40817810000110000011", "6123456789"),
                new Supplier("Аптека Протек", "Россия, Красноярск, ул. Ленина, 8", "+7 391 123-45-67", "ВТБ", "40702810607080909090", "7734567890"),
                new Supplier("МедСнаб", "Казахстан, Алматы, ул. Абая, 50", "+7 727 123-45-67", "Halyk Bank", "KZ1234001234567890", "1856349208")
            };

            var producer1 = new Manufacturer("ООО Фарма", "Россия, Москва, ул. Ленина, 1", "+7 800 555-35-35");
            var producer2 = new Manufacturer("ФармГлобал", "Германия, Берлин, ул. Бранденбург, 20", "+49 30 123456");
            var producer3 = new Manufacturer("Зеленый Лекарь", "Беларусь, Минск, ул. Советская, 5", "+375 17 1234567");

            // Создание упаковок
            var packaging1 = new Packaging("Блистерная упаковка", "Пластик", 10);
            var packaging2 = new Packaging("Пластиковая бутылка", "Пластик", 100);
            var packaging3 = new Packaging("Стеклянный флакон", "Стекло", 50);

            List<Medicine> Medicines = new List<Medicine>
            {
                new Medicine("Парацетамол", "Обезболивающее", new DateTime(2023, 1, 15), new DateTime(2025, 1, 15), "1234567890", producer1, packaging1),
                new Medicine("Аспирин", "Обезболивающее", new DateTime(2022, 6, 1), new DateTime(2024, 6, 1), "2345678901", producer2, packaging2),
                new Medicine("Ибупрофен", "Противовоспалительное", new DateTime(2023, 3, 20), new DateTime(2025, 3, 20), "3456789012", producer3, packaging3),
                new Medicine("Лоперамид", "Противодиарейное", new DateTime(2023, 7, 10), new DateTime(2025, 7, 10), "4567890123", producer1, packaging1),
                new Medicine("Цитрамон", "Обезболивающее", new DateTime(2022, 10, 5), new DateTime(2024, 10, 5), "5678901234", producer2, packaging2),
                new Medicine("Каламин", "Антисептик", new DateTime(2023, 5, 15), new DateTime(2025, 5, 15), "6789012345", producer3, packaging3),
                new Medicine("Супрастин", "Антигистаминное", new DateTime(2023, 2, 28), new DateTime(2025, 2, 28), "7890123456", producer1, packaging1),
                new Medicine("Тамифлю", "Противовирусное", new DateTime(2023, 4, 10), new DateTime(2025, 4, 10), "8901234567", producer2, packaging2),
                new Medicine("Фервекс", "Простуда", new DateTime(2022, 12, 1), new DateTime(2024, 12, 1), "9012345678", producer3, packaging3),
                new Medicine("Нурофен", "Обезболивающее", new DateTime(2023, 8, 8), new DateTime(2025, 8, 8), "0123456789", producer1, packaging1)
            };

            SuppliersComboBox.DataSource = suppliers;
            SuppliersComboBox.DisplayMember = "Name";

            MedicinesComboBox.DataSource = Medicines;
            MedicinesComboBox.DisplayMember = "Name";
        }
        public Supplier supplier
        {
            get { return (Supplier)this.SuppliersComboBox.SelectedItem; }
            set { this.SuppliersComboBox.SelectedItem = value; }
        }

        public Medicine medicine
        {
            get { return (Medicine)this.MedicinesComboBox.SelectedItem;}
            set { this.SuppliersComboBox.SelectedItem = value;}
        }

        public string Id
        {
            get { return this.IdBox.Text; }
            set { this.IdBox.Text = value; }
        }
        public DateTime date
        {
            get { return DateTime.Parse(this.DateBox.Text); }
            set { this.DateBox.Text = value.ToString(); }
        }
        public decimal price
        {
            get { return decimal.Parse(this.PriceBox.Text); }
            set { this.PriceBox.Text = value.ToString(); }
        }

        public int count
        {
            get { return int.Parse(this.CountBox.Text); }
            set { this.CountBox.Text = value.ToString();}
        }

        private void ComeBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(IdBox.Text))
            {
                MessageBox.Show("Введите ID.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!DateTime.TryParse(DateBox.Text, out DateTime parsedDate))
            {
                MessageBox.Show("Введите корректную дату в формате ДД.ММ.ГГГГ.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!decimal.TryParse(PriceBox.Text, out decimal parsedPrice) || parsedPrice <= 0)
            {
                MessageBox.Show("Введите корректную положительную цену.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!int.TryParse(CountBox.Text, out int parsedCount) || parsedCount <= 0)
            {
                MessageBox.Show("Введите корректное положительное количество.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (SuppliersComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите поставщика.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (MedicinesComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите лекарство.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            presenter.SetAdderView(this);
            presenter.AddDeliveryNote();
        }
        
        
        private void SuppliersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier selectedSupplier = (Supplier)SuppliersComboBox.SelectedItem;
            
        }

        private void MedicinesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicine selectedMedicine = (Medicine)MedicinesComboBox.SelectedItem;
            
        }

        public Presenter.DeliveryNotePresenter presenter { private get; set; }
    }
}
