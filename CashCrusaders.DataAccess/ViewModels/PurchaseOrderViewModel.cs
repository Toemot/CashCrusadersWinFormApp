using CashCrusaders.DataAccess.Command;
using CashCrusaders.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders.DataAccess
{
    public class PurchaseOrderViewModel : ViewModelBase
    {
        private readonly PurchaseOrder _purchaseOrder;
        private readonly IPurchaseOrderData _orderData;

        public PurchaseOrderViewModel(PurchaseOrder purchaseOrder, IPurchaseOrderData orderData)
        {
            _purchaseOrder = purchaseOrder;
            _orderData = orderData;
            SaveCommand = new DelegateCommand(Save, () => CanSave);
            
        }

        public DelegateCommand SaveCommand { get; }

        public int PurchaseOrderNumber
        {
            get => _purchaseOrder.PurchaseOrderNumber;
            set
            {
                if (_purchaseOrder.PurchaseOrderNumber != value)
                {
                    _purchaseOrder.PurchaseOrderNumber = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteEventChanged();
                }
            }
        }

        public int? ProductId
        {
            get => _purchaseOrder.ProductId;
            set
            {
                if (_purchaseOrder.ProductId != value)
                {
                    _purchaseOrder.ProductId = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteEventChanged();
                }
            }
        }

        public int? SupplierId
        {
            get => _purchaseOrder.SupplierId;
            set
            {
                if (_purchaseOrder.SupplierId != value)
                {
                    _purchaseOrder.SupplierId = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteEventChanged();
                }
            }
        }

        public int? Quantity
        {
            get => _purchaseOrder.Quantity;
            set
            {
                if (_purchaseOrder.Quantity != value)
                {
                    _purchaseOrder.Quantity = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteEventChanged();
                }
            }
        }

        public decimal? Subtotal
        {
            get => _purchaseOrder.Subtotal;
            set
            {
                if (_purchaseOrder.Subtotal != value)
                {
                    _purchaseOrder.Subtotal = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteEventChanged();
                }
            }
        }

        public decimal? Tax
        {
            get => _purchaseOrder.Tax;
            set
            {
                if (_purchaseOrder.Tax != value)
                {
                    _purchaseOrder.Tax = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteEventChanged();
                }
            }
        }

        public decimal? GrandTotal
        {
            get => _purchaseOrder.GrandTotal;
            set
            {
                if (_purchaseOrder.GrandTotal != value)
                {
                    _purchaseOrder.GrandTotal = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteEventChanged();
                }
            }
        }


        public bool CanSave => !string.IsNullOrEmpty(PurchaseOrderNumber.ToString());

        public void Save()
        {
            _orderData.SavePurchaseOrder(_purchaseOrder);
        }
    }
}
