using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TradeASP.Models
{
    public class GoodContext : DbContext
    {
        
        public DbSet<Good> Goods { get; set; }
        
        //public void addInfo(string name1, int price1, string delivery1, string description1)
        //{
        //    Goods.Add(new Good(name1, price1, delivery1, description1));
        //}

        public GoodContext(DbContextOptions<GoodContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
