﻿using RC.Shop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RC.Shop.Models.Goods
{
    public class OrderVM
    {
        public List<OrderInfo> OrderItemList { get; set; } = new List<OrderInfo>();

    }
}
