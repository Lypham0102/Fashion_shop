using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Fashion_shop.Models
{
    public class Cart
    {
        public List<Cart_Details> Cart_Details { get; set; }
        public float Total { get; set; }

        public Cart()
        {
            Cart_Details = new List<Cart_Details>();
        }

        public Cart(List<Cart_Details> cart_Details)
        {
            Cart_Details = cart_Details;
            Total = cart_Details.Sum(tt => tt.total);

        }

    }
}
