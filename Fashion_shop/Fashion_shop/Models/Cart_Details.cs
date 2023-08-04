using System;

namespace Fashion_shop.Models
{
    public class Cart_Details
    {
        public int Id { get; set; }
        //public DateTime Date { get; set; }
        public int Total { get; set; }
        public int Id_Details_Item { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Image { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}
