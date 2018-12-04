using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RC.Shop.Data;
using RC.Shop.Models;

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

    }
}
