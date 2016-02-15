using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class SubMenuEntity
    {

        public int SubMenuID { get; set; }
        public string SubMenuItem { get; set; }
        public int MenuID { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool IsVariant { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifyDate { get; set; }
        public string LastModifyBy { get; set; }
        public bool IsActive { get; set; }


    }
}
