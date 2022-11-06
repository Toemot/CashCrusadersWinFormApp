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

namespace CashCrusaders.WFApp.Product
{
    public partial class ProductForm : Form
    {
        CashCrusadersDbContext Context = new CashCrusadersDbContext();

        private readonly MainViewModel _viewModel;

        public ProductForm()
        {
            InitializeComponent();
            //_viewModel = new MainViewModel(new ProductData(Context));
        }
    }
}
