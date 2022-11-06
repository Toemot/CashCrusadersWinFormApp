using CashCrusaders.DataAccess;
using CashCrusaders.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashCrusaders.WFApp
{
    public partial class MainForm : Form
    {
        CashCrusadersDbContext Context = new CashCrusadersDbContext();

        private readonly MainViewModel _viewModel;

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new MainViewModel(new SupplierData(Context));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _viewModel.Load();
            supplierBindingSource.DataSource = _viewModel.Suppliers;
            lstSuppliers.DataSource = supplierBindingSource;
            lstSuppliers.DisplayMember = "SupplierName";

            txtSupplierCode.DataBindings.Add("Text", supplierBindingSource, "SupplierCode",
                false, DataSourceUpdateMode.OnPropertyChanged);
            txtSupplierName.DataBindings.Add("Text", supplierBindingSource, "SupplierName",
                false, DataSourceUpdateMode.OnPropertyChanged);
            btnCreate.DataBindings.Add("Enabled", supplierBindingSource, "CanSave");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (supplierBindingSource.Current is SupplierViewModel supplier && supplier.CanSave)
            {
                supplier.Save();
            }
        }
    }
}
