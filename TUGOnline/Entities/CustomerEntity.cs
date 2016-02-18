using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CustomerEntity
    {

        public string CustomerID { get; set; }
        public string Password { get; set; }
        public string FristName { get; set; }
        public string Lastname { get; set; }
        public Nullable<System.DateTime> Dob { get; set; }
        public string EmailID { get; set; }
        public string MobileNumber { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }



    }
}
