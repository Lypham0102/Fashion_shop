using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fashion_shop.Data;
using Fashion_shop.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Org.BouncyCastle.Crypto.Generators;
using Bcrypt = BCrypt.Net.BCrypt;
using Microsoft.AspNetCore.Http;

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
            var vouchers = await _context.Voucher.ToListAsync();
            return View(vouchers);
        }
        // GET: Items/Create
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voucher = await _context.Voucher.FindAsync(id);
            if (voucher == null)
            {
                return NotFound();
            }
            return View(voucher);
        }
        // POST: Items/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Voucher voucher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(voucher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(voucher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name,Start,End_dates,Count,Discount")] Voucher voucher)
        {
            if (id != voucher.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(voucher); // Đánh dấu đối tượng là đã sửa đổi
                    await _context.SaveChangesAsync(); // Lưu thay đổi vào cơ sở dữ liệu
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VoucherExists(voucher.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index)); // Chuyển hướng sau khi cập nhật thành công
            }
            return View(voucher);
        }
        private bool VoucherExists(int id)
        {
            return _context.Voucher.Any(e => e.id == id);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voucher = await _context.Voucher
                .FirstOrDefaultAsync(m => m.id == id);
            if (voucher == null)
            {
                return NotFound();
            }

            return View(voucher);
        }


    }

}

