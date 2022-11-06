using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders.DataAccess.Repository
{
    public interface IProductData
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task SaveProductAsync(Product product);
    }
}
