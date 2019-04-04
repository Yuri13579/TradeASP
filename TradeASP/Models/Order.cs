using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeASP.Models
{
    public class Order
    {
        public string id { get; set; }
        public int amount { get; set; }
        public DateTime date { get; set; }
        public string goodId { get; set; }
        public string customerID { get; set; }
    }
}
