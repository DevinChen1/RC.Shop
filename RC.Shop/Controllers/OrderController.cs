using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RC.Shop.Core;
using RC.Shop.Core.Domain.Product;
using RC.Shop.Data;
using RC.Shop.Models;
using RC.Shop.Models.Goods;

namespace RC.Shop.Controllers
{
    public class OrderController : Controller
    {
        private readonly ShopDBContext _context;

        public OrderController(ShopDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 去下单 todo
        /// </summary>
        /// <returns></returns>
        public IActionResult PlaceOrder(List<ProductInfo> goodsList)
        {
            OrderInfo vm = new OrderInfo();
            
            return View(vm);
        }
        public IActionResult GetOrderList(string userId)
        {
            OrderVM vm = new OrderVM();
            vm.OrderItemList = _context.OrderInfos.Where(x => x.Uid == userId).ToList();
            return Json(vm);
        }
        public IActionResult GetOrderGoodsList(string oId)
        {
            OrderGoodsVM vm = new OrderGoodsVM();
            vm.OrderGoodsList = _context.OrderProductInfos.Where(x => x.Oid == oId).ToList();
            return Json(vm);
        }

    }
}
