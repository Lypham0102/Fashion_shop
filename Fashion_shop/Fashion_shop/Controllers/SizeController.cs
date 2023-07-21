using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fashion_shop.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fashion_shop.Controllers
{
    public class SizeController : Controller
    {
        private readonly AppDbContext _context;

        public SizeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public List<string> GetSizeName(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var itemDetails = _context.Size
                .Where(details => details.id == id)
                .Select(details => details.Name)
                .ToList();

            return itemDetails;
        }
    }
}

