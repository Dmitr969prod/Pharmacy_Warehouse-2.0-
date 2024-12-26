using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseClient.View.Suppliers;

namespace Pharmacy_Warehouse_2._0_.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly ISupplierView _supplierView;

        public MainPresenter(IMainView view, ISupplierView supplierView)
        {
            _view = view;
            _supplierView = supplierView;

            _view.LoadSupplierForm += OnLoadSupplierView;
        }

        private void OnLoadSupplierView(object sender, EventArgs e) 
        {
            
            _supplierView.Show();
        }
    }
}
