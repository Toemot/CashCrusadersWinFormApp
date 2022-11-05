using System;
using System.Collections.Generic;
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

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void SaveProduct(Product product)
        {
            _context.SaveChanges();
        }
    }
}
