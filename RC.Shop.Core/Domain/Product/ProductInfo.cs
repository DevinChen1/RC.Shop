using RC.Shop.Core.Domain.Product.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace RC.Shop.Core.Domain.Product
{
    /// <summary>
    /// 商品信息类
    /// </summary>
    public class ProductInfo
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [Key]
        public string Pid { get; set; }=Guid.NewGuid().ToString("N");//商品id
        /// <summary>
        /// 商品货号
        /// </summary>
        public string Psn { get; set; }//商品货号
    
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }//商品名称
        /// <summary>
        /// 商品商城价
        /// </summary>
        public decimal? Shopprice { get; set; } = 0M;//商品商城价
        /// <summary>
        /// 商品市场价
        /// </summary>
        public decimal? Marketprice { get; set; } = 0M;//商品市场价
        /// <summary>
        /// 商品成本价
        /// </summary>
        public decimal? Costprice { get; set; } = 0M;//商品成本价
        /// <summary>
        /// 0代表上架，
        /// 1代表下架，
        /// 2代表回收站
        /// </summary>
        public ProductState? State { get; set; } = ProductState.OnSale;//0代表上架，1代表下架，2代表回收站
        /// <summary>
        /// 商品是否精品
        /// </summary>
        public bool? IsBest { get; set; } = false;//商品是否精品
        /// <summary>
        /// 商品是否热销
        /// </summary>
        public bool? IsHot { get; set; } = false;//商品是否热销
        /// <summary>
        /// 商品是否新品
        /// </summary>
        public bool? IsNew { get; set; } = false;//商品是否新品
        /// <summary>
        /// 商品排序
        /// </summary>
        public int? Displayorder { get; set; } = 0;//商品排序
        /// <summary>
        /// 商品重量
        /// </summary>
        public int? Weight { get; set; } = 1;//商品重量
        /// <summary>
        /// 商品重量描述
        /// </summary>
        public string WeightDescription { get; set; }
        /// <summary>
        /// 商品展示图片
        /// </summary>
        public string ShowImg { get; set; } = "";//商品展示图片
        /// <summary>
        /// 销售数
        /// </summary>
        public int? SaleCount { get; set; } = 0;//销售数
        /// <summary>
        /// 访问数
        /// </summary>
        public int? VisitCount { get; set; } = 0;//访问数
        /// <summary>
        /// 评价数
        /// </summary>
        public int? ReviewCount { get; set; } = 0;//评价数
        /// <summary>
        /// 评价星星
        /// </summary>
        public ProductStar? Star { get; set; } = ProductStar.START1;//评价星星
        /// <summary>
        /// 商品添加时间
        /// </summary>
        public DateTime? Addtime { get; set; } = DateTime.Now;//商品添加时间

        /// <summary>
        /// 商品描述
        /// </summary>
        public string Description { get; set; }//商品描述

        #region 库存
        /// <summary>
        /// 商品库存数量
        /// </summary>
        public int? Number { get; set; } = 100;//商品库存数量
        /// <summary>
        /// 商品库存警戒线
        /// </summary>
        public int? Limit { get; set; } = 100;//商品库存警戒线

        #endregion


    }
}

