using System;
using System.ComponentModel.DataAnnotations;

namespace RC.Shop.Core.Domain.Product
{
    /// <summary>
    /// 商品图片信息类
    /// </summary>
    public class ProductImageInfo
    {
        public ProductImageInfo() { PImgId = Guid.NewGuid().ToString("N"); }
        /// <summary>
        /// 商品图片id
        /// </summary>
        [Key]
        public string PImgId { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public string Pid { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string ShowImg { get; set; }
        /// <summary>
        /// 是否为主图
        /// </summary>
        public bool? IsMain { get; set; } = false;
        /// <summary>
        /// 商品图片排序
        /// </summary>
        public int? DisplayOrder { get; set; } = 0;
    }
}
