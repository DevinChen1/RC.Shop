using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RC.Shop.Data
{
    public class ShopDBContext : DbContext
    {
        public ShopDBContext(DbContextOptions<ShopDBContext> options)
            : base(options)
        {

        }
        //public DbSet<RegionInfo> RegionInfos { get; set; }
        //public DbSet<ShipAddressInfo> ShipAddressInfos { get; set; }

        

    }
}
