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

        public InvoicePresenter(IInvoiceView invoiceView, IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
            _invoiceView = invoiceView;
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
            var newInvoice = new Invoice(
                Guid.NewGuid().ToString(),
                DateTime.Now,
                new Customer("Новый клиент", "Адрес", "Телефон", "ИНН"),
                "Новый продавец",
                new DeliveryItem(
                    new Medicine("Новое лекарство", "Категория", DateTime.Now, DateTime.Now.AddYears(2), "РегНомер", null, null),
                    0,
                    0
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
