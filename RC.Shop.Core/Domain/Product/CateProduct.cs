using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RC.Shop.Core.Domain.Product
{
   public class CateProduct
    {
        [Key]
        public string Id { get; set; }= Guid.NewGuid().ToString("N");
        public string CateId { set; get; }//分类id
        public string Pid { get; set; }//商品id
    }
}
