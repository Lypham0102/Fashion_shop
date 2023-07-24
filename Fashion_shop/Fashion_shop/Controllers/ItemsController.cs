using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fashion_shop.Data;
using Fashion_shop.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Fashion_shop.Controllers
{
    public class ItemsController : Controller
    {
        private readonly AppDbContext _context;
        private MaterialsController ctMaterials;
        private User_ItemController ctUserItems;
        private Product_TypeController ctProductTypes;
        private Item_DetailsController ctItem_Details;

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
        public ActionResult Index(int ? page)
        {
            const int pageSize = 40; // Số mục trên mỗi trang
            int pageNumber = (page ?? 1); // Số trang hiện tại (nếu không có, mặc định là trang 1)

            var select = SelectItem(1000).ToPagedList(pageNumber, pageSize);
            return View(select);
        }
        public async Task<IActionResult> Details(int? id)
        {
            ctMaterials = new MaterialsController(_context);
            ctUserItems = new User_ItemController(_context);
            ctProductTypes = new Product_TypeController(_context);
            ctItem_Details = new Item_DetailsController(_context);
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

            var b = await ctUserItems.Details(item.User_Item_id);
            ViewBag.B = b;

            var c = await ctProductTypes.Details(item.Product_Type_id);
            ViewBag.C = c;

            // Gọi phương thức GetColors trên đối tượng ctItem_Details và lưu kết quả vào biến colors
            var d = await ctItem_Details.GetColors(item.id);
            //ViewBag.D = d.Select(color => color.Name).ToList();

            // Gọi phương thức GetSizes trên đối tượng ctItem_Details và lưu kết quả vào biến sizes
            var e = await ctItem_Details.GetSizes(item.id);
            //ViewBag.E = e.Select(size => size.Name).ToList();
            Item_list il;
            il = new Item_list(item, d, e);

            return View("Details", il); // Truyền giá trị của item và ViewBag.A vào view "Details"
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
