using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Warehouse.Model.Suppliers;
using Pharmacy_Warehouse_2._0_.Presenter;
using Pharmacy_Warehouse_2._0_.View.Suppliers;
using WarehouseClient.Presenter;

namespace Pharmacy_Warehouse_2._0_
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new MainForm();
            var viewSupplier = new SupplierForm();
            var repository = new SupplierJsonRepository("supplier.json");

            var MainPresenter = new MainPresenter(view, viewSupplier);
            var presenter = new SuplierPresenter(viewSupplier, repository);

            Application.Run(view);
        }
    }
}
