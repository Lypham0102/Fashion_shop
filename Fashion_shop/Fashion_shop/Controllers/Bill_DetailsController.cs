using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fashion_shop.Data;
using Fashion_shop.Models;
using Microsoft.AspNetCore.Http;

namespace Fashion_shop.Controllers
{
    public class Bill_DetailsController : Controller
    {
        private readonly AppDbContext _context;

        public Bill_DetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Bill_Details
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bill_Details.ToListAsync());
        }

        // GET: Bill_Details/Details/5
        public async Task<IActionResult> Details(int? id_details_item, int? Bill_id)
        {
            if (id_details_item == null || Bill_id == null)
            {
                return NotFound();
            }

            var bill_Details = await _context.Bill_Details
                .FirstOrDefaultAsync(m => m.id_details_item == id_details_item && m.Bill_id == Bill_id );
            if (bill_Details == null)
            {
                return NotFound();
            }

            return View(bill_Details);
        }

        // GET: Bill_Details/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bill_Details/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Bill_id,id_details_item,Total,Count")] Bill_Details bill_Details)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bill_Details);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bill_Details);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToCart([Bind("id_details_item,Total,Count")] Bill_Details bill_Details)
        {
            //BillsController bc = new BillsController(_context);
            int Bill_id = 0;
            if (Request.Cookies["Bill_id"] != null)
            {
                 Bill_id = Int32.Parse(Request.Cookies["Bill_id"]);
            }           
            var bill = await _context.Bill.FirstOrDefaultAsync(b => b.id == Bill_id && b.Status == "0");
            if(bill == null)
            {
                //User u = new User();
                Bill b = new Bill();
                //Bill_id = bc.Bill_Gen(b);
                //Them cac du lieu cho Bill vao
                //Them cac du lieu cho Bill vao
                //Them cac du lieu cho Bill vao
                //Them cac du lieu cho Bill vao
                //Them cac du lieu cho Bill vao
                _context.Add(b);
                await _context.SaveChangesAsync();
                Bill_id = b.id;
            }

            /*int? Bill_id = HttpContext.Session.GetInt32("Bill_id");
            if (Bill_id.HasValue)
            {
                bill_Details.Bill_id = Bill_id.Value;
            }
            else
            {

            }*/   
            bill_Details.Bill_id = Bill_id;
            if (ModelState.IsValid)
            {
                _context.Add(bill_Details);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bill_Details);
        }
        // GET: Bill_Details/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill_Details = await _context.Bill_Details.FindAsync(id);
            if (bill_Details == null)
            {
                return NotFound();
            }
            return View(bill_Details);
        }

        // POST: Bill_Details/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Bill_id,id_details_item,Total,Count")] Bill_Details bill_Details)
        {
            if (id != bill_Details.id_details_item)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bill_Details);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Bill_DetailsExists(bill_Details.id_details_item))
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
            return View(bill_Details);
        }

        // GET: Bill_Details/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill_Details = await _context.Bill_Details
                .FirstOrDefaultAsync(m => m.id_details_item == id);
            if (bill_Details == null)
            {
                return NotFound();
            }

            return View(bill_Details);
        }

        // POST: Bill_Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bill_Details = await _context.Bill_Details.FindAsync(id);
            _context.Bill_Details.Remove(bill_Details);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Bill_DetailsExists(int id)
        {
            return _context.Bill_Details.Any(e => e.id_details_item == id);
        }
    }
}
