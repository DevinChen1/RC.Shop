using Microsoft.EntityFrameworkCore;
using RC.Shop.Core;
using RC.Shop.Core.Domain.Product;
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
        #region 产品领域
        public DbSet<ProductInfo> ProductInfos { get; set; }
        public DbSet<CateProduct> CateProducts { get; set; }
        public DbSet<CategoryInfo> CategoryInfos { get; set; }
        #endregion
        #region 订单领域
        public DbSet<CartProductInfo> CartProductInfos { get; set; }
  
        public DbSet<OrderInfo> OrderInfos { get; set; }
        public DbSet<OrderProductInfo> OrderProductInfos { get; set; }
        #endregion
        #region 用户领域
        public DbSet<RegionInfo> RegionInfos { get; set; }
        public DbSet<ShipAddressInfo> ShipAddressInfos { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        /// <summary>
        /// 用户等级信息类
        /// </summary>
        public DbSet<UserRankInfo> UserRankInfos { get; set; }

        #endregion

    }
}
