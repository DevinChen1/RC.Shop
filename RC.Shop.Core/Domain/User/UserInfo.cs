using System;
using System.ComponentModel.DataAnnotations;

namespace RC.Shop.Core
{
    /// <summary>
    /// 用户信息类
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        ///用户id
        /// </summary>
        [Key]
        public string Uid { get; set; }
        /// <summary>
        /// 微信ID
        /// </summary>
        public string WeChatId { get; set; }
        /// <summary>
        ///用户名称
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 用户手机
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }
        ///<summary>
        ///用户管理员组id
        ///</summary>
        public string AdminGid { get; set; }
        ///<summary>
        ///用户等级id
        ///</summary>
        public int UserRid { get; set; } = 1;
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string Avatar { get; set; }
        ///<summary>
        ///支付积分
        ///</summary>
        public int PayCredits { get; set; } = 0;
        /// <summary>
        /// 等级积分
        /// </summary>
        public int RankCredits { get; set; } = 0;
        /// <summary>
        /// 是否验证邮箱
        /// </summary>
        public bool VerifyEmail { get; set; } = false;
        /// <summary>
        /// 是否验证手机
        /// </summary>
        public bool VerifyMobile { get; set; } = false;
        /// <summary>
        /// 解禁时间
        /// </summary>
        public DateTime LiftBanTime { get; set; }
        /// <summary>
        /// 用户注册时间
        /// </summary>
        public DateTime RegisterTime { get; set; }
        ///<summary>
        ///用户性别(0代表未知，1代表男，2代表女)
        ///</summary>
        public int Gender { get; set; } = 0;
        ///<summary>
        ///用户出生日期
        ///</summary>
        public DateTime Bday { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdCard { get; set; }
        ///<summary>
        ///简介
        ///</summary>
        public string Bio { get; set; }
    }
}
