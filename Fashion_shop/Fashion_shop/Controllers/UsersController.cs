﻿using System;
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

namespace Fashion_shop.Controllers
{

    public class UsersController : Controller
    {

        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(User User)
        {
            if (ModelState.IsValid)
            {

                var confirm = Bcrypt.Verify(User.Password, Bcrypt.HashPassword(User.Password));
                var user = await _context.User.FirstOrDefaultAsync(u => u.Username == User.Username /*&& u.Password == User.Password*/);
                if(user != null && confirm)
                {
                    Response.Cookies.Append("User_Id",user.id.ToString());
                    Response.Cookies.Append("UserName", user.Name.ToString());
                    //HttpContext.Session.SetString("UserName", user.Name.ToString());

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Username),
                        new Claim(ClaimTypes.Role, user.Role_id.ToString()) // Gán vai trò vào claim
                    };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    if(user.Role_id.ToString() == Role.User.ToString())
                    {
                        return RedirectToAction("Index", "Home");

                    }
                    if (user.Role_id.ToString() == Role.Admin.ToString())
                    {
                        return RedirectToAction("Index", "Users");

                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");

                    }

                }    

                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }
            return View(User);
        }
        // Action để đăng xuất
        public IActionResult Logout()
        {
            // Xóa cookie
            Response.Cookies.Delete("UserName");

            // Chuyển hướng về trang Login
            return RedirectToAction("Index", "Home");
        } 

        public IActionResult DetailsUser()
        {
            var userId = Convert.ToInt32(Request.Cookies["User_Id"]);
            var user = _context.User.FirstOrDefault(u => u.id == userId);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        public IActionResult Logup()
        {
            var user = new User(); // Tạo đối tượng User mới
            return View(user);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logup([Bind("Name, Email, Gender, Username, Password, PhoneNumber, Address, Bank, CardNumber, Date_of_birth")] User user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _context.User.FirstOrDefaultAsync(u => u.Username == user.Username || u.Email == user.Email);
                if (existingUser != null)
                {
                    ModelState.AddModelError("Username", "The username or email is already in use.");
                    return View(user);
                }

                // Calculate age
                DateTime userbd = user.Date_of_birth;
                TimeSpan t = DateTime.Now.Subtract(userbd);
                if (t.TotalDays < (16 * 360))
                {
                    ModelState.AddModelError("Date_of_birth", "Read our policy for more information about age restriction");
                    return View(user);
                }

                // Hash the password before saving
                user.Password = Bcrypt.HashPassword(user.Password);
                user.Status = 1;

                _context.Add(user);
                await _context.SaveChangesAsync();

                // Automatically log in the user after successful registration
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Role, Role.User.ToString()) // Assuming newly registered users are assigned the "User" role
        };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "Home");
            }

            return View(user);
        }


        // GET: Users
        [Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.User.ToListAsync());
        }
        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        //[Authorize(Policy = "AdminOnly")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Email,Gender,Username,Password,PhoneNumber,Address,Bank,CardNumber,Date_of_birth")] User user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _context.User.FirstOrDefaultAsync(u => u.Username == user.Username /*|| u.Email == user.Email*/);
                if (existingUser != null)
                {
                    ModelState.AddModelError("Username", "The username or email is already in use.");
                    return Json(new { success = false, message = "The username or email is already in use." });
                }
                DateTime userbd = user.Date_of_birth;
                TimeSpan t = DateTime.Now.Subtract(userbd)  ;
                if (  t.TotalDays < (16*360))
                {
                    ModelState.AddModelError("Date_of_birth", "Read our policy for more information about age restriction");
                    return Json(new { success = false, message = "Hãy đọc chính sách về giới hạn độ tuổi" });
                }
                user.Password = Bcrypt.HashPassword(user.Password);
                user.Status = 1;
                _context.Add(user);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = "Successfully Sign up" });
                //return RedirectToAction(nameof(Index));
            }

            return Json(new { success = false, message = "Model invalid" });
        }
        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name,Email,Gender,Username,Password,PhoneNumber,Address,Bank,CardNumber,Date_of_birth")] User user)
        {
            if (id != user.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.FindAsync(id);
            if (user == null)
        {
            // Handle the situation where the user with the given id is not found
            return NotFound();
        }
            user.Status = 0;
            //_context.User.Update(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.id == id);
        }

    }
}
