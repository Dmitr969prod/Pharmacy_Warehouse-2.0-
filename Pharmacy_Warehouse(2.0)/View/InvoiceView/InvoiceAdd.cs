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
using System.Windows.Forms.VisualStyles;

namespace Pharmacy_Warehouse_2._0_.View.InvoiceView
{
    public partial class InvoiceAdd : Form, IInvoiceAddForm
    {
        public InvoiceAdd(InvoicePresenter Presenter)
        {
            InitializeComponent();
            presenter = Presenter;
            List<Customer> customers = new List<Customer>
            {
                new Customer("ООО Озерки", "Москва, ул. Ленина, 1", "+7 900 123-45-67", "123456789012"),
                new Customer("Аптека Здоровье", "Санкт-Петербург, ул. Пушкина, 10", "+7 900 234-56-78", "234567890123"),
                new Customer("Аптечный Дом", "Екатеринбург, ул. Свердлова, 12", "+7 900 345-67-89", "345678901234"),
                new Customer("Аптека 36,6", "Казань, ул. Лобачевского, 5", "+7 900 456-78-90", "456789012345"),
                new Customer("Семейная аптека", "Новосибирск, ул. Красный проспект, 15", "+7 900 567-89-01", "567890123456"),
                new Customer("Аптека Экспресс", "Челябинск, ул. Трубная, 3", "+7 900 678-90-12", "678901234567"),
                new Customer("Зеленая аптека", "Волгоград, ул. Победы, 7", "+7 900 789-01-23", "789012345678"),
                new Customer("Аптека у дома", "Воронеж, ул. Ленина, 8", "+7 900 890-12-34", "890123456789"),
                new Customer("Аптека Плюс", "Рязань, ул. Центральная, 20", "+7 900 901-23-45", "901234567890"),
                new Customer("Медицинская аптека", "Томск, ул. Советская, 18", "+7 900 012-34-56", "012345678901")
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

            CustomersComboBox.DataSource = customers;
            CustomersComboBox.DisplayMember = "Name";

            MedicinesComboBox.DataSource = Medicines;
            MedicinesComboBox.DisplayMember = "Name";
        }

        public string Id
        {
            get { return this.ID.Text; }
            set {  this.ID.Text = value; }
        }

        public Customer Customer
        {
            get { return (Customer)this.CustomersComboBox.SelectedItem; }
            set { this.CustomersComboBox.SelectedItem = value;}
        }

        public Medicine Medicine
        {
            get { return (Medicine)this.MedicinesComboBox.SelectedItem; }
            set { this.MedicinesComboBox.SelectedItem=value; }
        }

        public decimal PricePerUnit
        {
            get { return decimal.Parse(this.PriceBox.Text); }
            set { this.PriceBox.Text = value.ToString(); }
        }

        public int Quantity
        {
            get { return int.Parse(this.CountBox.Text);}
            set { this.CountBox.Text = value.ToString(); }
        }
        public string SellerName
        {
            get { return this.SellerNameBox.Text; }
            set { this.SellerNameBox.Text = value; }
        }
        public DateTime date
        {
            get { return DateTime.Parse(this.DateBox.Text);}
            set { this.DateBox.Text = value.ToString(); }   
        }

        

        private void MedicinesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicine SelectMedicine = (Medicine) MedicinesComboBox.SelectedItem;
        }

        private void ComeBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer SelectCustomer = (Customer)CustomersComboBox.SelectedItem;
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Проверка ID
            if (string.IsNullOrWhiteSpace(ID.Text))
            {
                MessageBox.Show("Введите идентификатор счета.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка выбранного клиента
            if (CustomersComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите клиента из списка.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка выбранного лекарства
            if (MedicinesComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите медикамент из списка.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка цены за единицу
            if (!decimal.TryParse(PriceBox.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Введите корректную цену за единицу (положительное число).", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка количества
            if (!int.TryParse(CountBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Введите корректное количество (целое положительное число).", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка имени продавца
            if (string.IsNullOrWhiteSpace(SellerNameBox.Text))
            {
                MessageBox.Show("Введите имя продавца.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка даты
            if (!DateTime.TryParse(DateBox.Text, out DateTime date) || date > DateTime.Now)
            {
                MessageBox.Show("Введите корректную дату (она не может быть в будущем).", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            presenter.SetAdderView(this);
            presenter.AddInvoice();
        }
        public Presenter.InvoicePresenter presenter { private get; set; }
    }
}
