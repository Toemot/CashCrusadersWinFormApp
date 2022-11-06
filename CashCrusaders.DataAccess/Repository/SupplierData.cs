using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
        {
            return await _context.Suppliers.ToListAsync();
        }

        public async Task SaveSupplierAsync(Supplier supplier)
        {
            await _context.SaveChangesAsync();
        }
    }
}
