﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fashion_shop.Data;
using Fashion_shop.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using Org.BouncyCastle.Bcpg;
using System.Drawing;
using Microsoft.AspNetCore;
using Newtonsoft.Json;
using System.Text;

namespace Fashion_shop.Controllers
{
    public class BillsController : Controller
    {
        private readonly AppDbContext _context;

        public BillsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Bills
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bill.ToListAsync());
        }

        public async Task<List<Cart_Details>> Cart_Details_Session()
        {
            var cart = HttpContext.Session.Get("Cart");
            List<Cart_Details> listCartDetails = new List<Cart_Details>();
            if (cart != null)
            {
                var cartJson = Encoding.UTF8.GetString(cart);
                var cartDetails = JsonConvert.DeserializeObject<List<Bill_Details>>(cartJson);
                
                foreach (var item in cartDetails)
                {
                    Cart_Details temp_item = new Cart_Details();
                    temp_item.Id_Details_Item = item.id_details_item;
                    temp_item.Count = item.Count;
                    //temp_item.Date = DateTime.Now;

                    temp_item.ItemId = _context.Item_Details
                        .Where(m => m.id_details_item == item.id_details_item)
                        .Select(m => m.Item_id)
                        .FirstOrDefault();

                    temp_item.SizeId = _context.Item_Details
                        .Where(m => m.id_details_item == item.id_details_item)
                        .Select(m => m.Size_id)
                        .FirstOrDefault();

                    temp_item.ColorId = _context.Item_Details
                        .Where(m => m.id_details_item == item.id_details_item)
                        .Select(m => m.Color_id)
                        .FirstOrDefault();

                    temp_item.ColorName = _context.Color
                        .Where(c => c.id == temp_item.ColorId)
                        .Select(c => c.Name)
                        .FirstOrDefault();


                    temp_item.SizeName = _context.Size
                        .Where(c => c.id == temp_item.SizeId)
                        .Select(c => c.Name)
                        .FirstOrDefault();

                    temp_item.ItemName = _context.Item
                       .Where(c => c.id == temp_item.ItemId)
                       .Select(c => c.Name)
                       .FirstOrDefault();

                    temp_item.Price = _context.Item
                       .Where(c => c.id == temp_item.ItemId)
                       .Select(c => c.Price)
                       .FirstOrDefault();

                    temp_item.Total = temp_item.Count*temp_item.Price;


                    temp_item.Image = _context.Item
                       .Where(c => c.id == temp_item.ItemId)
                       .Select(c => c.Image)
                       .FirstOrDefault();

                    listCartDetails.Add(temp_item);
                }
                // Add code here to update the session-based cart

                // Serialize the updated cart back to JSON and save it in the session
            }
            return listCartDetails;
        }
            public async Task<List<Cart_Details>> Cart_Details(int userId)
            {
            List<Cart_Details> cartDetails = await _context.Bill
                  .Where(b => b.Status == 0 && b.User_id == userId)
                  .Join(
                      _context.Bill_Details,
                      bill => bill.id,
                      bill_details => bill_details.Bill_id,
                      (bill, bill_details) => new
                      {
                          Id = bill.id,
                          //Date = bill.Date,
                          Total = bill_details.Total * bill_details.Count,
                          Count = bill_details.Count,
                          Id_Details_Item = bill_details.id_details_item
                      }
                  )
                  .Join(
                      _context.Item_Details,
                      billDetails => billDetails.Id_Details_Item,
                      itemDetails => itemDetails.id_details_item,
                      (billDetails, itemDetails) => new
                      {
                          Id = billDetails.Id,
                          Id_Details_Item = billDetails.Id_Details_Item,
                          //Date = billDetails.Date,
                          Total = billDetails.Total,
                          Count = billDetails.Count,
                          ColorId = itemDetails.Color_id,
                          SizeId = itemDetails.Size_id,
                          ItemId = itemDetails.Item_id
                      }
                  )
                  .Join(_context.Color,
                  itemColor => itemColor.ColorId,
                  color => color.id,
                   (itemColor, color) => new
                   {
                       Id = itemColor.Id,
                       Id_Details_Item = itemColor.Id_Details_Item,
                       //Date = itemColor.Date,
                       Total = itemColor.Total,
                       Count = itemColor.Count,
                       ColorId = itemColor.ColorId,
                       SizeId = itemColor.SizeId,
                       ItemId = itemColor.ItemId,
                       ColorName = color.Name
                   })
                  .Join(_context.Size,
                  itemSize => itemSize.SizeId,
                  size => size.id,
                   (itemSize, size) => new
                   {
                       Id = itemSize.Id,
                       Id_Details_Item = itemSize.Id_Details_Item,
                       //Date = itemSize.Date,
                       Total = itemSize.Total,
                       Count = itemSize.Count,
                       ColorId = itemSize.ColorId,
                       SizeId = itemSize.SizeId,
                       ItemId = itemSize.ItemId,
                       ColorName = itemSize.ColorName,
                       SizeName = size.Name
                   })
                  .Join(
                      _context.Item,
                      itemDetail => itemDetail.ItemId,
                      item => item.id,
                      (itemDetail, item) => new Cart_Details
                      {
                          Id = itemDetail.Id,
                          Id_Details_Item = itemDetail.Id_Details_Item,
                          //Date = itemDetail.Date,
                          Total = item.Price * itemDetail.Count,
                          ColorId = itemDetail.ColorId,
                          ColorName = itemDetail.ColorName,
                          SizeId = itemDetail.SizeId,
                          SizeName = itemDetail.SizeName,
                          ItemId = itemDetail.ItemId,
                          ItemName = item.Name,
                          Image = item.Image,
                          Price = item.Price,
                          Count = itemDetail.Count
                      }
                  )
                  .OrderBy(m => m.Id_Details_Item)
                  .ToListAsync();
            return cartDetails;
        }

        // GET: Bills
        public async Task<IActionResult> Cart()
        {
            if (Request.Cookies["User_Id"] != null)
            {
                var userId = int.Parse(Request.Cookies["User_Id"]);
                // Fetch cart details and associated item details using multiple joins
                List<Cart_Details> cartDetails = await Cart_Details(userId);
                if (cartDetails == null)
                {
                    cartDetails = await Cart_Details_Session();
                    if(cartDetails == null)
                    {
                        return View();
                    }
                }
                ViewBag.Total = cartDetails.Sum( t => t.Total );
                // Fetch and return other relevant data to the view
                return View(cartDetails);
            }
            else
            {
                List<Cart_Details> cartDetails = await Cart_Details_Session();
                if (cartDetails == null)
                {
                    return View();
                }
                ViewBag.Total = cartDetails.Sum(t => t.Total);
                return View(cartDetails);

            }
            // If the user is not authenticated, return an empty view
        }


        [HttpPost]
        public async Task<ActionResult> UpdateCount(int count, int bill_id, int item_details_id)
        {
            var billDetail = await _context.Bill_Details.FirstOrDefaultAsync(m => m.Bill_id == bill_id && m.id_details_item == item_details_id);

            if (billDetail != null)
            {
                billDetail.Count = count;
                await _context.SaveChangesAsync();
            }

            return new EmptyResult();
        }


        // GET: Bills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill = await _context.Bill
                .FirstOrDefaultAsync(m => m.id == id);
            if (bill == null)
            {
                return NotFound();
            }

            return View(bill);
        }

        // GET: Bills/Create
        public IActionResult Create()
        {
            return View();
        }

        /*public async Task<int> Bill_Gen(Bill bill)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bill);
                int Bill_id = bill.id;
                await _context.SaveChangesAsync();
                //HttpContext.Session.SetInt32("Bill_id", Bill);
                Response.Cookies.Append("Bill_id", Bill_id.ToString());
                return Bill_id;
            }
            return -1;
        }*/
        // POST: Bills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Date_Time,Total,Staff_id,Customer_id,Voucher_id")] Bill bill)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bill);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bill);
        }
        
        // GET: Bills/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill = await _context.Bill.FindAsync(id);
            if (bill == null)
            {
                return NotFound();
            }
            return View(bill);
        }

        // POST: Bills/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Date_Time,Total,Staff_id,Customer_id,Voucher_id")] Bill bill)
        {
            if (id != bill.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BillExists(bill.id))
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
            return View(bill);
        }

        // GET: Bills/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill = await _context.Bill
                .FirstOrDefaultAsync(m => m.id == id);
            if (bill == null)
            {
                return NotFound();
            }

            return View(bill);
        }

        // POST: Bills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bill = await _context.Bill.FindAsync(id);
            _context.Bill.Remove(bill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BillExists(int id)
        {
            return _context.Bill.Any(e => e.id == id);
        }
    }
}
