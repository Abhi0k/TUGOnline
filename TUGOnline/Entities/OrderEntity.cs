using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class OrderEntity
    {

        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int AddressID { get; set; }
        public decimal SubTotalAmount { get; set; }
        public decimal ServiceTax { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal DiscountedAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public int StatusID { get; set; }
        public int StoreID { get; set; }
        public int PaymentDI { get; set; }
        public string Remark { get; set; }
        public string OfferCode { get; set; }
        public  DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime lastModifydate { get; set; }
        public string LastModifyBy { get; set; }
        public int DeliveriPersonID { get; set; }

    }
}
