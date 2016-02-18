using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class ProductEntity
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImagePath { get; set; }
        public bool IsTopping { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastModifyDate { get; set; }
        public string LastModifyBy { get; set; }
        public bool IsActive { get; set; }

        public ICollection<SubProductEntity> SubProducts { get; set; }

    }
}
