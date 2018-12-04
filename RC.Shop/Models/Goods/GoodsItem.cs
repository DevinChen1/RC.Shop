using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RC.Shop.Models.Goods
{
    public class GoodsItem
    {
        /// <summary>
        /// 物品Id
        /// </summary>
        public string GoodsPid { get; internal set; }
        /// <summary>
        /// 物品编号
        /// </summary>
        public string GoodsNo { get; set; }
        /// <summary>
        /// 物品排序号
        /// </summary>
        public int? GoodsIndex { get; set; }
        /// <summary>
        /// 物品类别
        /// </summary>
        public string GoodsType { get; set; }
        /// <summary>
        /// 物品类别排序号
        /// </summary>
        public int? GoodsTypeIndex { get; set; }
        /// <summary>
        /// 物品类别Id
        /// </summary>
        public string GoodsTypeId { get; set; }
        /// <summary>
        /// 物品图片
        /// </summary>
        public string GoodsImg { get; set; }
        /// <summary>
        /// 物品名称  
        /// </summary>
        public string GoodsName { get; set; }
        /// <summary>
        /// 商品商城价
        /// </summary>
        public decimal? Shopprice { get; set; }
        /// <summary>
        /// 商品市场价
        /// </summary>
        public decimal? Marketprice { get; set; } = 0M;//商品市场价
        /// <summary>
        /// 物品描述
        /// </summary>
        public string GoodsDescription { get; set; }
        /// <summary>
        /// 销量
        /// </summary>
        public int? SaleCount { get; set; } = 0;
        
    }
}
