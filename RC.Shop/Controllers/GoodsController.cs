using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RC.Shop.Data;
using RC.Shop.Models.Goods;

namespace RC.Shop.Controllers
{
    public class GoodsController : Controller
    {
        private readonly ShopDBContext _context;

        public GoodsController(ShopDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetGoodsVM()
        {
            GoodsVM vm = new GoodsVM();
            ///todo
            return Json(vm);
        }


    }
}