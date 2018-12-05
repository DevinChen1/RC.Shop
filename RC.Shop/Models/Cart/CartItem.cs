using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RC.Shop.Models.Cart
{
    public class CartItem
    {

        /// <summary>
        /// 是否选中
        /// </summary>
        public bool? IsSelected { get; set; } = false;
        public string UserId { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public string Pid { get; set; }
        /// <summary>
        /// 商品编码
        /// </summary>
        public string PSN { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 商品展示图片
        /// </summary>
        public string ShowImg { get; set; }
        /// <summary>
        /// 商城价格
        /// </summary>
        public decimal? ShopPrice { get; set; } = 0M;
        /// <summary>
        /// 商品市场价格
        /// </summary>
        public decimal? MarkeSPrice { get; set; } = 0M;
        /// <summary>
        /// 重量： 0.6斤
        /// </summary>
        public string WeightString { get; set; }
        /// <summary>
        /// 购物车数量
        /// </summary>
        public int? Count { get; set; } = 1;
        /// <summary>
        /// 放入购物车时间
        /// </summary>
        public DateTime? AddTime { get; set; } = DateTime.Now;

    }
}
