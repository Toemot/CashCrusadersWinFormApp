using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders.DataAccess.Repository
{
    public class SupplierData : ISupplierData
    {
        private readonly CashCrusadersDbContext _context;

        public SupplierData(CashCrusadersDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }

        public void SaveSupplier(Supplier supplier)
        {
            _context.SaveChanges();
        }
    }
}
