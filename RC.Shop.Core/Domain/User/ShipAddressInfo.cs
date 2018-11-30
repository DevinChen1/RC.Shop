using System;
using System.ComponentModel.DataAnnotations;

namespace RC.Shop.Core
{
    /// <summary>
    /// 用户配送地址信息类
    /// </summary>
    public class ShipAddressInfo
    {

        /// <summary>
        /// 配送地址id
        /// </summary>
        [Key]
        public string SAId { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public string Uid { get; set; }
        /// <summary>
        /// 区域id
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// 是否是默认地址
        /// </summary>
        public bool IsDefault { get; set; } = false;
        /// <summary>
        /// 别名
        /// </summary>
        public string Alias { get; set; }
        /// <summary>
        /// 收货人
        /// </summary>
        public string Consignee { get; set; }
        /// <summary>
        /// 收货人手机
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 收货人固定电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 收货人邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
    }

}
