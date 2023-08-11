using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Fashion_shop.Models;
using Fashion_shop.Data;
using System.Globalization;
using System.Text;
using Microsoft.EntityFrameworkCore;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace Fashion_shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _dbContext;
        //private AppDbContext dbContext;
        public HomeController(ILogger<HomeController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Search(string keyword)
        {
            ViewBag.Keyword = keyword;
            keyword = keyword.ToLower();
            keyword = RemoveDiacritics(keyword);
            var allItems = _dbContext.Item.ToList();
            var result = allItems
                .Where(item => RemoveDiacritics(item.Name.ToLower()).Contains(keyword))
                .ToList();
            return View("SearchResult", result);
        }
        private static string RemoveDiacritics(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        public ActionResult SearchByCategory(int category)
        {
            List<Item> searchResults = new List<Item>();
            List<Item> allItems = _dbContext.Item.ToList();
            foreach (var item in allItems)
            {
                if (item.User_Item_id == category)
                {
                    searchResults.Add(item);
                }
            }

            return View("Seach", searchResults);
        }
        private List<Item> SelectItem()
        {
            var a = _dbContext.Item.OrderByDescending(a => a.id).Take(3).ToList();
            return a;
        }
        public IActionResult Index()
        {
            //var userName = Request.Cookies["UserName"];
            //var select = SelectItem();
            //return View(model: userName
            var userName = Request.Cookies["UserName"];
            var select = SelectItem();

            // Sử dụng ViewBag để truyền dữ liệu vào view
            ViewBag.UserName = userName;
            ViewBag.SeclectItems = select;

            return View();
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
        [HttpGet]
        public async Task<IActionResult> GetCounts()
        {
            int itemCount = await _dbContext.Item.CountAsync();
            int orderCount = await _dbContext.Bill.CountAsync();
            int voucherCount = await _dbContext.Voucher.CountAsync();

            var counts = new
            {
                ItemCount = itemCount,
                OrderCount = orderCount,
                VoucherCount = voucherCount
            };

            return Json(counts);
        }

    }
}

