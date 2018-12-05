using System;
using System.ComponentModel.DataAnnotations;

namespace RC.Shop.Core
{
    /// <summary>
    /// 订单商品信息类
    /// </summary>
    public class OrderProductInfo
    {
        /// <summary>
        /// 记录id
        /// </summary>
         [Key]
        public string RecordId { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        
        public string Oid { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public string Uid { get; set; }
        /// <summary>
        /// sessionId
        /// </summary>
        public string Sid { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public string Pid { get; set; }
        /// <summary>
        /// 商品编码
        /// </summary>
        public string PSN { get; set; }
        /// <summary>
        /// 分类id
        /// </summary>
        public string CateId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 商品展示图片
        /// </summary>
        public string ShowImg { get; set; }

        /// <summary>
        /// 商品商城价格
        /// </summary>
        public decimal ShopPrice { get; set; }
        /// <summary>
        /// 商品成本价格
        /// </summary>
        public decimal CostPrice { get; set; }
        /// <summary>
        /// 商品市场价格
        /// </summary>
        public decimal MarketPrice { get; set; }
        /// <summary>
        /// 商品重量
        /// </summary>
        public int Weight { get; set; } = 1;

        /// <summary>
        /// 真实数量
        /// </summary>
        public int RealCount { get; set; }
        /// <summary>
        /// 商品购买数量
        /// </summary>
        public int BuyCount { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
    }
}

