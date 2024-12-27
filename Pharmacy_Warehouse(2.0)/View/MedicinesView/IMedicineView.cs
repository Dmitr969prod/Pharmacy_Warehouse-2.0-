using Pharmacy_Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse_2._0_.View.MedicinesView
{
    public interface IMedicineView
    {
        event EventHandler LoadMainForm;
        IList<string> MedicineList { get; set; }
        int SelectedMedicine { get; set; }
        string Name { get; set; }
        string Category { get; set; }
        DateTime ManufactureDate { get; set; }
        DateTime ExpirationDate { get; set; }
        string RegNumber { get; set; }
        /* string Producer { get; set; }
         string PackagingInfo { get; set; }*/
        //void SetManufactureData(Manufacturer manufacture);
        Manufacturer GetManufactureData();
        //void SetPackingInfo(Packaging packaging);
        Packaging GetPackagingInfo();
        void Show();
        void Hide();
        Presenter.MedicinePresenter Presenter { set; }

    }
}
