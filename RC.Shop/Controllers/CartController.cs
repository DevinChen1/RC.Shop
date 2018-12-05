using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RC.Shop.Data;
using RC.Shop.Models.Cart;

namespace RC.Shop.Controllers
{
    public class CartController : Controller
    {
        private readonly ShopDBContext _context;

        public CartController(ShopDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCartVM(string userId)
        {
            CartVM vm = new CartVM();
            vm.CartItemList = (from CP in _context.CartProductInfos
                               where CP.Uid == userId
                               select new CartItem
                               {
                                   AddTime = CP.AddTime,
                                   Count = CP.CartCount,
                                   IsSelected = CP.IsSelected,
                                   Name = CP.Name,
                                   Pid = CP.Pid,
                                   PSN = CP.PSN,
                                   ShopPrice = CP.ShopUnitPrice,
                                   MarkeSPrice = CP.MarkeUnittPrice,
                                   ShowImg = CP.ShowImg,
                                   WeightString = CP.WeightString

                               }).ToList();

            return Json(vm);
        }
    }
}