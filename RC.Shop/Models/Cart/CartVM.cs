using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RC.Shop.Models.Cart
{
    public class CartVM
    {
        public List<CartItem> CartItemList { get; set; } = new List<CartItem>();
    }
}
