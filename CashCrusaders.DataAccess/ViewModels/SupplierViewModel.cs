using CashCrusaders.DataAccess.Command;
using CashCrusaders.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders.DataAccess
{
    public class SupplierViewModel : ViewModelBase
    {
        private readonly Supplier _supplier;
        private readonly ISupplierData _supplierData;

        public SupplierViewModel(Supplier supplier, ISupplierData supplierData)
        {
            _supplier = supplier;
            _supplierData = supplierData;
            SaveCommand = new DelegateCommand(Save, () => CanSave);
        }

        public DelegateCommand SaveCommand { get; }

        public string SupplierCode
        {
            get => _supplier.SupplierCode;
            set
            {
                if (_supplier.SupplierCode != value)
                {
                    _supplier.SupplierCode = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteEventChanged();
                }
            }
        }

        public string SupplierName
        {
            get => _supplier.SupplierName;
            set
            {
                if (_supplier.SupplierName != value)
                {
                    _supplier.SupplierName = value;
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteEventChanged();
                }
            }
        }

        public bool CanSave => !string.IsNullOrEmpty(SupplierName);

        public void Save()
        {
            _supplierData.SaveSupplier(_supplier);
        }
    }
}
