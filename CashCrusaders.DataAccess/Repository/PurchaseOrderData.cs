using System;
using System.Collections.Generic;
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

        public IEnumerable<PurchaseOrder> GetAllPurchaseOrder()
        {
            return _context.PurchaseOrders.ToList();
        }

        public void SavePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            _context.SaveChanges();
        }
    }
}
