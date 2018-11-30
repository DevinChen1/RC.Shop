using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RC.Shop.Core
{
    /// <summary>
    /// 购物车项
    /// </summary>
    public class CartProductInfo
    {
        /// <summary>
        /// 记录id
        /// </summary>
        [Key]
        public string RecordId { get; set; }
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelected { get; set; } = false;
        /// <summary>
        /// 用户id
        /// </summary>
        public string Uid { get; set; }
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
        /// 商城单价
        /// </summary>
        public decimal ShopUnitPrice { get; set; } = 0M;
        /// <summary>
        /// 商品市场价格
        /// </summary>
        public decimal MarkeUnittPrice { get; set; } = 0M;
        /// <summary>
        /// 重量： 0.6斤
        /// </summary>
        public string WeightString { get; set; }
        /// <summary>
        /// 购物车数量
        /// </summary>
        public int CartCount { get; set; } = 1;
        /// <summary>
        /// 放入购物车时间
        /// </summary>
        public DateTime AddTime { get; set; }
    }
}
