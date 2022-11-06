using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCrusaders.DataAccess.Repository
{
    public interface ISupplierData
    {
        Task<IEnumerable<Supplier>> GetAllSuppliersAsync();
        Task SaveSupplierAsync(Supplier supplier);
    }
}
