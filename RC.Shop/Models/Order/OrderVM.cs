﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RC.Shop.Models.Goods
{
    public class OrderVM
    {
        public List<OrderItem> OrderItemList { get; set; } = new List<OrderItem>();

    }
}
