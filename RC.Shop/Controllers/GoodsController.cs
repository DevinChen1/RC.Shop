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
            vm.goodsList = (from CP in _context.CateProducts
                            join P in _context.ProductInfos on CP.Pid equals P.Pid
                            join C in _context.CategoryInfos on CP.CateId equals C.CateId
                            select new GoodsItem
                            {

                                GoodsPid = P.Pid,
                                GoodsDescription = P.Description,
                                SaleCount = P.SaleCount,
                                Shopprice = P.Shopprice,
                                GoodsImg = P.ShowImg,
                                GoodsIndex = P.Index,
                                GoodsName = P.Name,
                                GoodsNo = P.Psn,
                                GoodsType = C.Name,
                                GoodsTypeId = C.CateId,
                                GoodsTypeIndex = C.Index,
                                Marketprice = P.Marketprice
                            }).ToList();

            return Json(vm);
        }


    }
}