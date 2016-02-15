using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PaymentEntity
    {
        public int PaymentID { get; set; }
        public string PaymentType { get; set; }
        public string TransactionID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentTime { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsCod { get; set; }
    }
}
