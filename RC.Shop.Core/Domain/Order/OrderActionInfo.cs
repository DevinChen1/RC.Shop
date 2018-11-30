using RC.Shop.Core.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace RC.Shop.Core
{
    /// <summary>
    /// 订单处理信息类
    /// </summary>
    public class OrderActionInfo
    {

        /// <summary>
        /// 处理id
        /// </summary>
        [Key]
        public string Aid { get; set; }
        /// <summary>
        /// 订单id
        /// </summary>
        public int Oid { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>  
        public int Uid { get; set; }
        /// <summary>
        /// 真实名称
        /// </summary>
        public string RealName { get; set; }
        /// <summary>
        /// 管理员组id
        /// </summary>
        public int AdminGid { get; set; }
        /// <summary>
        /// 管理员组标题
        /// </summary>
        public string AdminGTitle { get; set; }
        /// <summary>
        /// 处理类型
        /// </summary>
        public OrderActionType ActionType { get; set; } = OrderActionType.Confirm;
        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime ActionTime { get; set; }
        /// <summary>
        /// 处理描述
        /// </summary>
        public string ActionDes { get; set; }
    }
}
