using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Fashion_shop.Models;
using Fashion_shop.Data;

namespace Fashion_shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private AppDbContext dbContext;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var userName = Request.Cookies["UserName"];
            return View(model: userName);
        }

        public IActionResult Store()
        {
            var userName = Request.Cookies["UserName"];
            return View(model: userName);
        }
        public IActionResult Details_item()
        {
            var userName = Request.Cookies["UserName"];
            return View(model: userName);
        }

        public IActionResult Contact()
        {
            var userName = Request.Cookies["UserName"];
            return View(model: userName);
        }

        public IActionResult Privacy()
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

