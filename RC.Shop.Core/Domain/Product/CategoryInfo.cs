using System;
using System.ComponentModel.DataAnnotations;

namespace RC.Shop.Core.Domain.Product
{
    /// <summary>
    /// 分类信息类
    /// </summary>
	public class CategoryInfo
    {
        public CategoryInfo() { CateId = Guid.NewGuid().ToString("N"); }


        /// <summary>
        /// 分类id
        /// </summary>
        [Key]
        public string CateId { set; get; }//分类id
        /// <summary>
        /// 分类排序
        /// </summary>
        public int? DisplayOrder { set; get; } = 0;
        /// <summary>
        /// 分类名称
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 分类价格范围
        /// </summary>
        public string PriceRange { set; get; }
        /// <summary>
        /// 父id
        /// </summary>
        public string ParentId { set; get; }
        /// <summary>
        /// 层级
        /// </summary>
        public int? Layer { set; get; } = 0;
        /// <summary>
        /// 是否有子节点
        /// </summary>
        public bool? HasChild { set; get; } = false;
        /// <summary>
        /// 分类路径
        /// </summary>
        public string Path { set; get; }
        public int? Index { get; set; } = 0;
    }
}

