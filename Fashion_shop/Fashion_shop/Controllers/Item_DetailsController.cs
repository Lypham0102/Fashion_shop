using System;
using System.Collections.Generic;
using System.Drawing;
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
        private ColorController _ctColor;
        private SizeController _ctSize;

        public Item_DetailsController(AppDbContext context)
        {
            _context = context;  
        }
        // GET: Item_Details/GetColors/5
        public async Task<List<Models.Color>> GetColors(int? id)
        {
            //_ctColor = new ColorController(_context);
            if (id == null)
            {
                return null;
            }

            var itemDetails = await _context.Item_Details
                .Where(details => details.Item_id == id)
                .Select(details => details.Color_id)
                .ToListAsync();

            var colorNames = new List<Models.Color>();
            foreach (var colorId in itemDetails)
            {
                // Gọi phương thức GetColorsName
                //var colorName = _ctColor.GetColorsName(colorId);
                var colorName = await _context.Color
                .FirstOrDefaultAsync(color => color.id == colorId);
                colorNames.Add(colorName); // Thêm tất cả các tên màu sắc vào danh sách colorNames
            }

            return colorNames;
        }

        // GET: Item_Details/GetSizes/5
        public async Task<List<Models.Size>> GetSizes(int? id)
        {
            _ctSize = new SizeController(_context);
            if (id == null)
            {
                return null;
            }
            var itemDetails = await _context.Item_Details
                .Where(details => details.Item_id == id)
                .Select(details => details.Size_id)
                .ToListAsync();

            var sizeNames = new List<Models.Size>();
            foreach (var sizeId in itemDetails)
            {
                // Gọi phương thức GetSizeName
                var sizeName = await _context.Size
                .FirstOrDefaultAsync(size => size.id == sizeId);
                sizeNames.Add(sizeName); // Thêm tất cả các tên màu sắc vào danh sách colorNames
            }

            return sizeNames;
        }
    }
}

