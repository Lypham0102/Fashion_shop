using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Fashion_shop.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fashion_shop.Controllers
{
    public class ColorController : Controller
    {
        private readonly AppDbContext _context;

        public ColorController(AppDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public List<string> GetColorsName(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var itemDetails = _context.Color
                .Where(details => details.id == id)
                .Select(details => details.Name)
                .ToList(); 

            return itemDetails;
        }
    }
}

