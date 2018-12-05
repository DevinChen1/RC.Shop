using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RC.Shop.Core;
using RC.Shop.Data;
using RC.Shop.Models.Me;

namespace RC.Shop.Controllers
{
    public class MeController : Controller
    {
        private readonly ShopDBContext _context;

        public MeController(ShopDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            RC.Shop.Comm.RCLog.Debug(this,"adadvavas");
            return View();
        }
        public IActionResult MyShipAddress(string uid)
        {
            var vm = _context.ShipAddressInfos.Where(x => x.Uid == uid).ToList();
            return View(vm);
        }
        public IActionResult GetUserInfo(string uid)
        {
            var vm = _context.UserInfos.FirstOrDefault(x => x.Uid == uid);
            return Json(vm);
        }
        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Login(loginDto request)
        {

            return RedirectToAction("Index", "Me");
        }
        public IActionResult AddAddress(string uid)
        {
            ShipAddressInfo vm = new ShipAddressInfo() { Uid = uid };
            return View(vm);
        }
        [HttpPost]
        public IActionResult AddAddress(ShipAddressInfo address)
        {

            _context.ShipAddressInfos.Add(address);
            _context.SaveChanges();
            return RedirectToAction("MyShipAddress", "Me");
        }
    }
}