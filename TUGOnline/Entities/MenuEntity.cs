using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class MenuEntity
    {

        public int MenuID { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool IsTopping { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifByDate { get; set; }
        public string LastModifyBy { get; set; }
        public bool IsActive { get; set; }

    }
}
