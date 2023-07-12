using System;

namespace Fashion_shop.Models
{
    public class Cart_Details
    {
        public Item item { get; set; }
        public float total { get; set; }
        public int count { get; set; }
        public Cart_Details(Item item,int soluong) 
        { 
            count = soluong;
            total = item.Price * soluong;
            this.item = item;
        }
    }
}
