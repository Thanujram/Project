﻿using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers.MainSection
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
