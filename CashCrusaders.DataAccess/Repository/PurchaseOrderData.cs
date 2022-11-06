using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders.DataAccess.Repository
{
    public class PurchaseOrderData : IPurchaseOrderData
    {
        private readonly CashCrusadersDbContext _context;

        public PurchaseOrderData(CashCrusadersDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PurchaseOrder>> GetAllPurchaseOrderAsync()
        {
            return await _context.PurchaseOrders.ToListAsync();
        }

        public async Task SavePurchaseOrderAsync(PurchaseOrder purchaseOrder)
        {
            await _context.SaveChangesAsync();
        }
    }
}
