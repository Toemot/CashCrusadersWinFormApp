using CashCrusaders.DataAccess.Command;
using CashCrusaders.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders.DataAccess
{
    public class MainViewModel : ViewModelBase
    {
        private SupplierViewModel _supplierViewModel;
        private readonly ISupplierData _supplierData;

        public MainViewModel(ISupplierData supplierData)
        {
            _supplierData = supplierData;
            LoadCommand = new DelegateCommand(Load);
        }

        public DelegateCommand LoadCommand { get; }

        public ObservableCollection<SupplierViewModel> Suppliers { get; } = new ObservableCollection<SupplierViewModel>();

        public SupplierViewModel SelectedSupplier
        {
            get => _supplierViewModel;
            set 
            {
                if (_supplierViewModel != value)
                {
                    _supplierViewModel = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(IsSupplierSelected));
                }
            }
        }

        public bool IsSupplierSelected => SelectedSupplier != null;

        public void Load()
        {
            var suppliers = _supplierData.GetAllSuppliers();
            Suppliers.Clear();
            foreach (var supplier in suppliers)
            {
                Suppliers.Add(new SupplierViewModel(supplier, _supplierData));
            }
        }
    }
}
