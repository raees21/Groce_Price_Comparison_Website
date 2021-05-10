﻿using Groce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RazorPagesMovie.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Groce.Controllers
{
    public class HomeController : Controller
    {
        private readonly GroceryContext _groceryContext;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, GroceryContext groceryContext)
        {
            _groceryContext = groceryContext;
            _logger = logger;
        }

        public IActionResult Index()
        {

            ViewBag.Groceries = _groceryContext.Groceries.Find(2).GroceryName;
            Console.WriteLine($"Results: {ViewBag.Groceries}");
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
