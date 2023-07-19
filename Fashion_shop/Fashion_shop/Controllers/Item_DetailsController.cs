using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fashion_shop.Data;
using Fashion_shop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Fashion_shop.Controllers
{
    public class Item_DetailsController : Controller
    {
        private readonly AppDbContext _context;

        public Item_DetailsController(AppDbContext context)
        {
            _context = context;  
        }

        // GET: Item_Details/GetColors/5
        public async Task<int> GetSize(int? id)
        {
            if (id == null)
            {
                return 0;
            }

            var item = await _context.Item_Details.FirstOrDefaultAsync(a => a.id == id);
            if (item == null)
            {
                return 0;
            }

            return item.Size_id;

        }
        public async Task<int> GetColor(int? id)
        {
            if (id == null)
            {
                return 0;
            }

            var item = await _context.Item_Details.FirstOrDefaultAsync(a => a.id == id);
            if (item == null)
            {
                return 0;
            }

            return item.Color_id;

        }
        public async Task<Item_Details> GetItemDetailsByItemIdAsync(int itemId)
        {
            // Sử dụng AppDbContext để lấy thông tin chi tiết của sản phẩm dựa trên itemId
            return await _context.Item_Details.FirstOrDefaultAsync(d => d.Item_id == itemId);
        }
    }
}

