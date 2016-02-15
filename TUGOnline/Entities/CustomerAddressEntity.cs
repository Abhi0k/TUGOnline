using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class CustomerAddressEntity
    {

        public int AddressID { get; set; }
        public string CustomerID { get; set; }
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string Locality { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
        public string LandMark { get; set; }
        public string ContactNumber { get; set; }
        public bool IsLatest { get; set; }


    }
}
