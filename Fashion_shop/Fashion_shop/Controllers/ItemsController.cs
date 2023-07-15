using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fashion_shop.Data;
using Fashion_shop.Models;

namespace Fashion_shop.Controllers
{
    public class ItemsController : Controller
    {
        private readonly AppDbContext _context;
        private MaterialsController ctMaterials;
        private User_ItemController ctUserItems;
        private Product_TypeController ctProductTypes;

        public ItemsController(AppDbContext context)
        {
            _context = context;

        }

        private List<Item> SelectItem(int count)
        {
            var a = _context.Item.OrderByDescending(a => a.id).Take(count).ToList();
            return a;
        }

        // GET: Items
        public ActionResult Index()
        {
            var select = SelectItem(24); 
            return View(select);
        }


        public async Task<IActionResult> Details(int? id)
        {
            ctMaterials = new MaterialsController(_context);
            ctUserItems = new User_ItemController(_context);
            ctProductTypes = new Product_TypeController(_context);
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item.FirstOrDefaultAsync(m => m.id == id);
            if (item == null)
            {
                return NotFound();
            }

            var a = await ctMaterials.Details(item.Materials_id);
            ViewBag.A = a;

            var b = await ctUserItems.Details(item.User_Item_Id);
            ViewBag.B = b;

            var c = await ctProductTypes.Details(item.Product_Type_Id);
            ViewBag.C = c;

            return View("Details", item); // Truyền giá trị của item và ViewBag.A vào view "Details"
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
        public async Task<IActionResult> Create([Bind("id,Name,Brand,Color,Price,Gender,Count,Size,Country,Image,Materials_id,User_Item_Id,Product_Type_Id")] Item item)
        {
            if (ModelState.IsValid)
            {               
                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // GET: Items/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name,Brand,Color,Price,Gender,Count,Size,Country,Image,Materials_id,User_Item_Id,Product_Type_Id")] Item item)
        {
            if (id != item.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.id))
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
            return View(item);
        }

        // GET: Items/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .FirstOrDefaultAsync(m => m.id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Item.FindAsync(id);
            _context.Item.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(int id)
        {
            return _context.Item.Any(e => e.id == id);
        }
    }
}
