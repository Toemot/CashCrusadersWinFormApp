using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders.DataAccess.Repository
{
    public interface IPurchaseOrderData
    {
        Task<IEnumerable<PurchaseOrder>> GetAllPurchaseOrderAsync();
        Task SavePurchaseOrderAsync(PurchaseOrder purchaseOrder);
    }
}
