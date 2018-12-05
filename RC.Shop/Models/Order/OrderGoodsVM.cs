using RC.Shop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RC.Shop.Models.Goods
{
    public class OrderGoodsVM
    {

        public List<OrderProductInfo> OrderGoodsList { get; set; } = new List<OrderProductInfo>();

    }
}
