using Pharmacy_Warehouse;
using Pharmacy_Warehouse_2._0_.Model.Orders;
using Pharmacy_Warehouse_2._0_.View.InvoiceView;
using System;
using System.Linq;

namespace Pharmacy_Warehouse_2._0_.Presenter
{
    public class InvoicePresenter
    {
        private readonly IInvoiceView _invoiceView;
        private readonly IInvoiceRepository _invoiceRepository;
        private IInvoiceAddForm _invoiceAdd;

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
        public void SetAdderView(IInvoiceAddForm adderView) 
        {
            _invoiceAdd = adderView; 
            adderView.presenter = this;
            
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


        public void AddInvoice()
        {
           
            var newInvoice = new Invoice(
                _invoiceAdd.Id,
                _invoiceAdd.date,
                _invoiceAdd.Customer,
                _invoiceAdd.SellerName,
                new DeliveryItem(
                    _invoiceAdd.Medicine,
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
