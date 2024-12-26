using Pharmacy_Warehouse_2._0_.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse_2._0_
{
    public interface IMainView:IView
    {
        event Action OpenSupplierForm; // Событие для открытия окна SupplierForm
        
    }
}
