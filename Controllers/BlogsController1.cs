﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Easternts.Controllers
{
    public class BlogsController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
