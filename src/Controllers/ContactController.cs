﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Wyatt_Fleming.Controllers
{
    public class ContactController : Controller
    {
		[Route ("contact")]
        public IActionResult Index()
        {
            return View();
        }
    }
}