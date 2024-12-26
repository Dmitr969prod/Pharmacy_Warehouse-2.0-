using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseClient.View.Suppliers;
using Pharmacy_Warehouse.Model.Suppliers;
using Pharmacy_Warehouse;
using Pharmacy_Warehouse_2._0_;


namespace WarehouseClient.Presenter
{
    public class SuplierPresenter
    {
        private readonly ISupplierView _supplierView;
        private readonly ISupplierRepository _supplierRepository;
        
        

        public SuplierPresenter(ISupplierView supplierView, ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
            _supplierView = supplierView;
            supplierView.Presenter = this;

            _supplierView.LoadMainForm += OnLoadMainForm;

            UpdateSupplierListView();
        }

        private void OnLoadMainForm(object sender, EventArgs e)
        {
            _supplierView.Hide();
        }

        private void UpdateSupplierListView()
        {
            var suppliersName = from supplier in _supplierRepository.GetAllSuppliers() select supplier.Name;
            int selectedSupplier = _supplierView.SelectedSupplier >= 0 ? _supplierView.SelectedSupplier : 0;
            _supplierView.SupplierList = suppliersName.ToList();
            _supplierView.SelectedSupplier = selectedSupplier;
        }

        public void UpdateSupplierView(int p)
        {
            Supplier supplier = _supplierRepository.GetSupplier(p);
            _supplierView.Name = supplier.Name;
            _supplierView.Address = supplier.Address;
            _supplierView.PhoneNumber = supplier.Phone;
            _supplierView.BankName = supplier.BankName;
            _supplierView.AccountNumber = supplier.AccountNumber;
            _supplierView.TaxID = supplier.TaxId;
        }
        public void AddSupplier() 
        {
            Supplier supplier = new Supplier();
            _supplierRepository.AddSupplier( supplier);
            UpdateSupplierListView();
        }

        public void SaveSupplier()
        {
            Supplier supplier = new Supplier(_supplierView.Name, _supplierView.Address, _supplierView.PhoneNumber,
                _supplierView.BankName, _supplierView.AccountNumber, _supplierView.TaxID);
            _supplierRepository.SaveSupplier(_supplierView.SelectedSupplier, supplier);
            UpdateSupplierListView();
        }



    }
}