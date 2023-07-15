using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fashion_shop.Data;
using Fashion_shop.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fashion_shop.Controllers
{
    public class User_ItemController : Controller
    {
        private readonly AppDbContext _context;

        public User_ItemController(AppDbContext context)
        {
            _context = context;

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public async Task<string> Details(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var item = await _context.User_Item.FirstOrDefaultAsync(a => a.id == id);
            if (item == null)
            {
                return null;
            }

            return item.Name;
        }
    }
}

