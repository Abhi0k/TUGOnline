//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int SubProductID { get; set; }
        public string ToppingIDs { get; set; }
        public Nullable<int> VariantID { get; set; }
        public Nullable<decimal> ToppingAmount { get; set; }
        public Nullable<decimal> ItemPrice { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual SubProduct SubProduct { get; set; }
        public virtual Variant Variant { get; set; }
    }
}