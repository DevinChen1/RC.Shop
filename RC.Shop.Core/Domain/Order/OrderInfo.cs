using RC.Shop.Core.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace RC.Shop.Core
{
    /// <summary>
    /// 订单信息类
    /// </summary>
    public class OrderInfo
    {
        /// <summary>
        /// 订单id
        /// </summary>
        [Key]
        public string Oid { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OSN { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public string Uid { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public OrderState OrderState { get; set; } = OrderState.WaitPaying;
        /// <summary>
        /// 商品合计
        /// </summary>
        public decimal ProductAmount { get; set; }
        /// <summary>
        /// 订单合计
        /// </summary>
        public decimal OrderAmount { get; set; }
        /// <summary>
        /// 剩余金钱
        /// </summary>
        public decimal SurplusMoney { get; set; }
        /// <summary>
        /// 是否评价
        /// </summary>
        public bool IsReview { get; set; } = false;
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 配送单号
        /// </summary>
        public string ShipSN { get; set; }
        /// <summary>
        /// 配送方式系统名
        /// </summary>
        public string ShipSystemName { get; set; }
        /// <summary>
        /// 配送方式昵称
        /// </summary>
        public string ShipFriendName { get; set; }
        /// <summary>
        /// 配送时间
        /// </summary>
        public DateTime ShipTime { get; set; }
        /// <summary>
        /// 支付方式(0代表货到付款，1代表在线付款)
        /// </summary>
        public PayModeType PayMode { get; set; }
        /// <summary>
        /// 支付单号
        /// </summary>
        public string PaySN { get; set; }
        /// <summary>
        /// 支付方式系统名
        /// </summary>
        public string PaySystemName { get; set; }
        /// <summary>
        /// 支付方式昵称
        /// </summary>
        public string PayFriendName { get; set; }
        /// <summary>
        /// 支付时间
        /// </summary>
        public DateTime PayTime { get; set; }
        /// <summary>
        /// 配送区域id
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// 收货人
        /// </summary>
        public string Consignee { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 固话号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 邮政编码
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 最佳送货时间
        /// </summary>
        public DateTime BestTime { get; set; }
        /// <summary>
        /// 配送费用
        /// </summary>
        public decimal ShipFee { get; set; }
        /// <summary>
        /// 满减
        /// </summary>
        public int FullCut { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public decimal Discount { get; set; }
        /// <summary>
        /// 支付积分数量
        /// </summary>
        public int PayCreditCount { get; set; }
        /// <summary>
        /// 支付积分金额
        /// </summary>
        public decimal PayCreditMoney { get; set; }
        /// <summary>
        /// 优惠劵金额
        /// </summary>
        public int CouponMoney { get; set; } = 0;
        /// <summary>
        /// 重量
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// 买家备注
        /// </summary>
        public string BuyerRemark { get; set; } = "";
        /// <summary>
        /// ip地址
        /// </summary>
        public string IP { get; set; }
    }
}

