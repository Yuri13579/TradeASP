using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradeASP.Models
{
    public class Good
    {
        public string id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string delivery { get; set; }
        public string description { get; set; }

        //public Good() { }

        //public Good(string name, int price, string delivery, string description)
        //{
        //    this.name = name;
        //    this.price = price;
        //    this.delivery = delivery;
        //    this.description = description;
        //}
    }
}
