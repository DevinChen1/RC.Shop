﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RC.Shop.Controllers
{
    public class MeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}