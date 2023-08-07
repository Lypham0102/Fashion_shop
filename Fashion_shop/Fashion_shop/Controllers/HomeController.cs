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
            // Trả về kết quả tìm kiếm dưới dạng danh sách sản phẩm và từ khóa tìm kiếm
            ViewBag.Keyword = keyword;

            keyword = keyword.ToLower();
            // Loại bỏ dấu khỏi từ khóa tìm kiếm
            keyword = RemoveDiacritics(keyword);

            // Lấy danh sách tất cả các mục từ cơ sở dữ liệu
            var allItems = _dbContext.Item.ToList();

            // Truy vấn dữ liệu trong C# sau khi loại bỏ dấu
            var result = allItems
                .Where(item => RemoveDiacritics(item.Name.ToLower()).Contains(keyword))
                .ToList();
            return View("SearchResult", result);
        }

        // Hàm loại bỏ dấu
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
            // Xử lý tìm kiếm dựa vào category và trả về trang hiển thị kết quả tìm kiếm
            List<Item> searchResults = new List<Item>();

            // Giả định có một danh sách các item trong cơ sở dữ liệu
            List<Item> allItems = _dbContext.Item.ToList();

            // Duyệt qua tất cả các item để tìm những item có User_Item_id bằng category
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
    }
}

