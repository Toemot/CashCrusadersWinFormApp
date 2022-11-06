using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders.DataAccess.Repository
{
    public class ProductData : IProductData
    {
        private readonly CashCrusadersDbContext _context;

        public ProductData(CashCrusadersDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task SaveProductAsync(Product product)
        {
            await _context.SaveChangesAsync();
        }
    }
}
