using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse_2._0_
{
    public interface IMainView
    {
        event EventHandler LoadSupplierForm;
        event EventHandler LoadMedicineForm;
        event EventHandler LoadDeliveryNoteForm;
        void Hide();
        void Show();
    }
}
