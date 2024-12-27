using Pharmacy_Warehouse;
using Pharmacy_Warehouse_2._0_.Model.Orders;
using Pharmacy_Warehouse_2._0_.View.InvoiceView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse_2._0_.Presenter
{
    public class InvoicePresenter
    {
        private readonly IInvoiceView _invoiceView;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IInvoiceAddForm _invoiceAdd;

        public InvoicePresenter(IInvoiceView invoiceView, IInvoiceRepository invoiceRepository, IInvoiceAddForm invoiceAdd)
        {
            _invoiceRepository = invoiceRepository;
            _invoiceView = invoiceView;
            _invoiceAdd = invoiceAdd;
            _invoiceAdd.presenter = this;
            _invoiceView.Presenter = this;

            _invoiceView.LoadMainForm += OnLoadMainForm;

            UpdateInvoiceListView();
        }

        private void OnLoadMainForm(object sender, EventArgs e)
        {
            _invoiceView.Hide();
        }

        private void UpdateInvoiceListView()
        {
            var invoices = _invoiceRepository.GetAllInvoices();
            var invoiceIds = invoices.Select(invoice => invoice.Id).ToList();

            int selectedInvoiceIndex = _invoiceView.SelectedInvoiceIndex >= 0
                ? _invoiceView.SelectedInvoiceIndex
                : 0;

            _invoiceView.InvoiceList = invoiceIds;
            _invoiceView.SelectedInvoiceIndex = selectedInvoiceIndex;

            if (invoices.Any() && selectedInvoiceIndex >= 0)
            {
                UpdateInvoiceView(selectedInvoiceIndex);
            }
        }

        public void UpdateInvoiceView(int index)
        {
            var invoice = _invoiceRepository.GetInvoiceById(index);
            if (invoice == null) return;

            _invoiceView.Id = invoice.Id;
            _invoiceView.Date = invoice.Date;
            _invoiceView.CustomerName = invoice.Customer.Name;
            _invoiceView.SellerName = invoice.SellerName;
            _invoiceView.MedicineName = invoice.DeliveryItem.Medicine.Name;
            _invoiceView.PricePerUnit = invoice.DeliveryItem.PricePerUnit;
            _invoiceView.Quantity = invoice.DeliveryItem.Quantity;
        }

        public void SaveInvoice()
        {
            var updatedInvoice = new Invoice(
                _invoiceView.Id,
                _invoiceView.Date,
                new Customer(
                    _invoiceView.CustomerName,
                    "Не указано", 
                    "Не указано", 
                    "Не указано"  
                ),
                _invoiceView.SellerName,
                new DeliveryItem(
                    new Medicine(
                        _invoiceView.MedicineName,
                        "Не указано", 
                        DateTime.MinValue, 
                        DateTime.MinValue,
                        "Не указано", 
                        null,
                        null
                    ),
                    _invoiceView.PricePerUnit,
                    _invoiceView.Quantity
                )
            );

            _invoiceRepository.UpdateInvoice(_invoiceView.SelectedInvoiceIndex, updatedInvoice);
            UpdateInvoiceListView();
        }

        public void AddInvoice()
        {
            var producer1 = new Manufacturer("Зеленый Лекарь", "Беларусь, Минск, ул. Советская, 5", "+375 17 1234567");


            var packaging1 = new Packaging("Блистерная упаковка", "Пластик", 10);
            var newInvoice = new Invoice(
                _invoiceAdd.Id,
                _invoiceAdd.date,
                new Customer(
                name: "ООО Здоровье",
                address: "г. Москва, ул. Лечебная, д. 1",
                phone: "+7 495 123-45-67",
                taxId: "7701234567"
            ),
                _invoiceAdd.SellerName,
                new DeliveryItem(
                    new Medicine("Парацетамол", "Обезболивающее", new DateTime(2023, 1, 15), new DateTime(2025, 1, 15), "1234567890", producer1, packaging1),
                    _invoiceAdd.PricePerUnit,
                    _invoiceAdd.Quantity
                )
            );

            _invoiceRepository.AddInvoice(newInvoice);
            UpdateInvoiceListView();
        }

        public void DeleteInvoice()
        {
            _invoiceRepository.DeleteInvoice(_invoiceView.SelectedInvoiceIndex);
            UpdateInvoiceListView();
        }
    }

}
