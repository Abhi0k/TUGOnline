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
    
    public partial class ORDER_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDER_MASTER()
        {
            this.ORDER_DETAILS = new HashSet<ORDER_DETAILS>();
        }
    
        public int ORDER_ID { get; set; }
        public string CUST_ID { get; set; }
        public int ADDRESS_ID { get; set; }
        public Nullable<decimal> SUBTOTAL_AMOUNT { get; set; }
        public Nullable<decimal> SERVICE_TAX { get; set; }
        public Nullable<decimal> SERVICE_CHARGE { get; set; }
        public Nullable<decimal> DISCOUNTED_AMOUNT { get; set; }
        public Nullable<decimal> TOTAL_AMOUNT { get; set; }
        public int STATUS_ID { get; set; }
        public int STORE_ID { get; set; }
        public int PAYMENT_ID { get; set; }
        public string REMARK { get; set; }
        public string OFFER_CODE { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> LASTMODIFIED_DATE { get; set; }
        public string LASTMODIFIED_BY { get; set; }
        public int DELIVERY_PERSON_ID { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual CUSTOMER_ADDRESS CUSTOMER_ADDRESS { get; set; }
        public virtual DELIVERY_STAFF DELIVERY_STAFF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_DETAILS> ORDER_DETAILS { get; set; }
        public virtual PAYMENT PAYMENT { get; set; }
        public virtual ORDER_STATUS ORDER_STATUS { get; set; }
        public virtual STORE STORE { get; set; }
    }
}
