using System;
using System.ComponentModel.DataAnnotations;

namespace RC.Shop.Core
{
    /// <summary>
    /// 用户等级信息类
    /// </summary>
    public class UserRankInfo
    {

        ///<summary>
        ///用户等级id
        ///</summary>
        [Key]
        public string UserRid { get; set; } = Guid.NewGuid().ToString("N");
    
        ///<summary>
        ///用户等级标题
        ///</summary>
        public string Title { get; set; }
        /// <summary>
        /// 用户等级头像
        /// </summary>
        public string Avatar { get; set; }
        ///<summary>
        ///用户等级积分上限
        ///</summary>
        public int CreditsUpper { get; set; }
        ///<summary>
        ///用户等级积分下限
        ///</summary>
        public int CreditsLower { get; set; }
 
    }
}
