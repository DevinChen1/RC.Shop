using RC.Shop.Core.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace RC.Shop.Core
{
    /// <summary>
    /// 订单售后服务信息类
    /// </summary>
    public class OrderAfterServiceInfo
    {


        /// <summary>
        /// 售后服务id
        /// </summary>
        [Key]
        public string ASId { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public OrderAfterServiceState State { get; set; } = OrderAfterServiceState.Checking;
        /// <summary>
        /// 用户id
        /// </summary>
        public string Uid { get; set; }
        /// <summary>
        /// 订单id
        /// </summary>
        public string Oid { get; set; }
        /// <summary>
        /// 记录id
        /// </summary>
        public string RecordId { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public string Pid { get; set; }
        /// <summary>
        /// 分类id
        /// </summary>
        public string CateId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string PName { get; set; }
        /// <summary>
        /// 商品图片
        /// </summary>
        public string PShowImg { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; } = 0;
        /// <summary>
        /// 金钱
        /// </summary>
        public decimal Money { get; set; }
        /// <summary>
        /// 类型(0代表退货,1代表换货,2代表维修)
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 申请原因
        /// </summary>
        public string ApplyReason { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime ApplyTime { get; set; }
        /// <summary>
        /// 审核结果
        /// </summary>
        public string CheckResult { get; set; }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime CheckTime { get; set; }

        /// <summary>
        /// 配送单号
        /// </summary>
        public string ShipSN1 { get; set; }
        /// <summary>
        /// 收货区域id
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// 收货人
        /// </summary>
        public string Consignee { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 固话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 邮件编码
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// 收货详细地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 邮寄给商城时间
        /// </summary>
        public DateTime SendTime { get; set; }
        /// <summary>
        /// 商城收货时间
        /// </summary>
        public DateTime ReceiveTime { get; set; }


    }
}
