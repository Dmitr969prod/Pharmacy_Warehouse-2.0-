using Pharmacy_Warehouse_2._0_.Common;
using WarehouseClient.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse_2._0_.Presenter
{
    public class MainFormPresenter: BasePresenter<IMainView>
    {
        public MainFormPresenter(IApplicationController controller, IMainView view):base(controller, view)
        {

        }

        private void OpenSupplierForm()
        {
            Controller.Run<SuplierPresenter>();

        }
    }
}
