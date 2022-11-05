//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CashCrusaders.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseOrder
    {
        public int PurchaseOrderId { get; set; }
        public int PurchaseOrderNumber { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> GrandTotal { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
