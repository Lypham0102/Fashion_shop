using System.Collections.Generic;
using System.Diagnostics;

namespace Fashion_shop.Models
{
    public class Cart
    {
        public List<Cart_Details> Cart_Details { get; set; }
        public int Total { get; set; }

        public Cart()
        {
            Cart_Details = new List<Cart_Details>();
        }

        public Cart(List<Cart_Details> cart_Details, int total)
        {
            Cart_Details = cart_Details;
            Total = total;
        }

    }
}
