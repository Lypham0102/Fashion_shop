using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Fashion_shop.Data;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;
using Fashion_shop.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using Org.BouncyCastle.Bcpg;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Text;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fashion_shop.Controllers
{
    public class VoucherController : Controller
    {
        private readonly AppDbContext _context;
        public VoucherController(AppDbContext context)
        {
            _context = context;

        }
        // GET: /<controller>/
        [Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Voucher.ToListAsync());
        }
        // GET: Items/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Name,Start, End_dates, Count, Discount")] Voucher voucher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(voucher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(voucher);
        }

    }

}

