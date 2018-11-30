using System;

namespace RC.Shop.Core.Domain.Enums
{
    /// <summary>
    /// 订单售后服务状态
    /// </summary>
    public enum OrderAfterServiceType
    {
        /// <summary>
        /// 退货
        /// </summary>
        Refund = 0,
        /// <summary>
        /// 换货
        /// </summary>
        replace = 1,
        /// <summary>
        /// 维修
        /// </summary>
        Repair = 2,
         
    }
}
