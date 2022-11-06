using CashCrusaders.DataAccess.Command;
using CashCrusaders.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders.DataAccess
{
    public class ProductViewModel : ViewModelBase
    {
        private readonly Product _product;
        private readonly IProductData _productData;

        public ProductViewModel(Product product, IProductData productData)
        {
            _product = product;
            _productData = productData;
            SaveCommand = new DelegateCommand(Save, () => CanSave);
        }

        public DelegateCommand SaveCommand { get; }

        public string ProductCode
        {
            get => _product.ProductCode;
            set
            {
                if (_product.ProductCode != value)
                {
                    _product.ProductCode = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteEventChanged();
                }
            }
        }

        public string Description
        {
            get => _product.Description;
            set
            {
                if (_product.Description != value)
                {
                    _product.Description = value;
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteEventChanged();
                }
            }
        }

        public decimal? Price
        {
            get => _product.Price;
            set
            {
                if (_product.Price != value)
                {
                    _product.Price = value;
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteEventChanged();
                }
            }
        }

        public bool CanSave => !string.IsNullOrEmpty(Description);

        public async void Save()
        {
            try
            {
                await _productData.SaveProductAsync(_product);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
