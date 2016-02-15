using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OrderDetailsEntity
    {

        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int SubMenuID { get; set; }
        public string ToppingIDs { get; set; }
        public int SubMenuVariantID { get; set; }
        public decimal TotalToppingAmount { get; set; }
        public decimal ItemPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
