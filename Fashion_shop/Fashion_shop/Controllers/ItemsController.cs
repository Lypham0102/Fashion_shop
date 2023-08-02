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
using Org.BouncyCastle.Bcpg;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Text;

namespace Fashion_shop.Controllers
{
    public class ItemsController : Controller
    {
        private readonly AppDbContext _context;
        private MaterialsController ctMaterials;
        private User_ItemController ctUserItems;
        private Product_TypeController ctProductTypes;
        private Item_DetailsController ctItem_Details;
        private readonly ILogger<ItemsController> _logger;
        public ItemsController(AppDbContext context, ILogger<ItemsController> logger)
        {
            _context = context;
            _logger = logger;

        }

        private List<Item> SelectItem(int count)
        {
            var a = _context.Item.OrderByDescending(a => a.id).Take(count).ToList();
            return a;
        }

        [Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> IndexAd()
        {
            return View(await _context.Item.ToListAsync());
        }

        public ActionResult Index(int? page)
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToCart(int itemId, int colorId, int sizeId)
        {
            // Check if all required parameters are provided
            /*            if (itemId == null || colorId == null || sizeId == null)
                        {
                            return BadRequest("Required parameters (itemId, colorId, and sizeId) are missing.");
                        }*/

            // Find the item detail based on provided parameters
            var itemDetail = await _context.Item_Details
                .FirstOrDefaultAsync(b => b.Item_id == itemId && b.Color_id == colorId && b.Size_id == sizeId);

            if (itemDetail == null)
            {
                itemDetail = new Item_Details
                {
                    Color_id = colorId,
                    Item_id = itemId,
                    Size_id = sizeId
                };
                _context.Add(itemDetail);
                await _context.SaveChangesAsync();
            }

            // Check if the user is logged in using the "User_Id" cookie
            if (Request.Cookies["User_Id"] != null)
            {
                var userId = int.Parse(Request.Cookies["User_Id"]);

                // Find an existing open (unpaid) "Bill" record associated with the user
                var bill = await _context.Bill
                    .FirstOrDefaultAsync(b => b.User_id == userId && b.Status == 0);

                // If no open "Bill" is found, create a new one
                if (bill == null)
                {
                    bill = new Bill
                    {
                        Total = 0,
                        Voucher_id = 0,
                        User_id = userId,
                        Date = DateTime.Now,
                        Status = 0
                    };

                    _context.Add(bill);
                    await _context.SaveChangesAsync();
                }

                // Check if the item is already in the user's cart (Bill_Details)
                var billDetails = await _context.Bill_Details
                    .FirstOrDefaultAsync(b => b.Bill_id == bill.id && b.id_details_item == itemDetail.id_details_item);
                _logger.LogDebug("Bill_Details not found for BillId: {BillId}, ItemDetailId: {ItemDetailId}", bill.id, itemDetail.id_details_item);
                // If not, create a new entry in Bill_Details
                if (billDetails != null)
                {
                    billDetails.Count++;
                    _context.Update(billDetails);
                }
                if (billDetails == null)
                {
                    billDetails = new Bill_Details
                    {
                        Bill_id = bill.id,
                        Total = 0,
                        id_details_item = itemDetail.id_details_item,
                        Count = 1 // Start with count as 1
                    };

                    _context.Add(billDetails);
                }
                // If the item is already in the cart, increment the count by 1

                await _context.SaveChangesAsync();
            }
            else
            {
                // Handle the case when the user is not logged in (session-based cart handling)
                var cart = HttpContext.Session.Get("Cart");
                if (cart != null)
                {
                    var cartJson = Encoding.UTF8.GetString(cart);
                    var cartDetails = JsonConvert.DeserializeObject<List<Bill_Details>>(cartJson);
                    var inCart = cartDetails.FirstOrDefault(c => c.id_details_item == itemDetail.id_details_item);
                    // Add code here to update the session-based cart
                    if (inCart != null)
                    {
                        inCart.Count++;
                        _logger.LogInformation("Item is already in the cart. Updated Count: {Count}, {item_details_id}", inCart.Count, inCart.id_details_item);
                    }
                    else
                    {
                        cartDetails.Add(new Bill_Details { Count = 1, id_details_item = itemDetail.id_details_item });
                    }

                    // Serialize the updated cart back to JSON and save it in the session
                    var updatedCartJson = JsonConvert.SerializeObject(cartDetails);
                    HttpContext.Session.Set("Cart", Encoding.UTF8.GetBytes(updatedCartJson));
                }
                else
                {
                    List<Bill_Details> cartDetails = new List<Bill_Details>();
                    cartDetails.Add(new Bill_Details { Count = 1, id_details_item = itemDetail.id_details_item });
                    var updatedCartJson = JsonConvert.SerializeObject(cartDetails);
                    HttpContext.Session.Set("Cart", Encoding.UTF8.GetBytes(updatedCartJson));
                }
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        [Authorize(Policy = "AdminOnly")]
        [Authorize(Policy = "UserOnly")]
        public async Task<IActionResult> PayMent()
        {
          
                var userId = int.Parse(Request.Cookies["User_Id"]);
                /*var userJson = HttpContext.Session.Get("User_Id");
                var user = Encoding.UTF8.GetString(userJson);
                var userId = JsonConvert.DeserializeObject<int>(user);*/
            var bill = await _context.Bill
                    .FirstOrDefaultAsync(b => b.User_id == userId && b.Status == 0);
            if (bill != null)
            {
                var billDetails = await _context.Bill_Details.ToListAsync();
                bill.Total = billDetails.Sum(t => t.Total);
                bill.Status = 1;
                bill.Date = DateTime.Now;
                await _context.SaveChangesAsync();
            }
            else
            {
                bill = new Bill
                {
                    Total = 0,
                    Voucher_id = 0,
                    User_id = userId,
                    Date = DateTime.Now,
                    Status = 0
                };
                _context.Add(bill);
                await _context.SaveChangesAsync();

                var cart = HttpContext.Session.Get("Cart");
                if (cart != null)
                {
                    var cartJson = Encoding.UTF8.GetString(cart);
                    var cartDetails = JsonConvert.DeserializeObject<List<Bill_Details>>(cartJson);
                    foreach(var  billDetails in cartDetails)
                    {
                        billDetails.Bill_id = bill.id;
                        _context.Add(billDetails);
                    }
                    bill.Status = 1;
                    await _context.SaveChangesAsync();
                }
                else
                {
                    return NotFound();
                }
                
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
