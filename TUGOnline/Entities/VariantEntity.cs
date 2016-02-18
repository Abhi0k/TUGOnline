using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class VariantEntity
    {
        public int VariantID { get; set; }
        public int SubProductID { get; set; }
        public string Name { get; set; }
        public string VariantDescription { get; set; }
        public string VariantImagePath { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastModifyDate { get; set; }
        public string LastModifyBy { get; set; }
        public Nullable<bool> IsActive { get; set; }


    }
}
