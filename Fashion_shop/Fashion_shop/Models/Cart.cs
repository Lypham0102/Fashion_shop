using System.Collections.Generic;

namespace Fashion_shop.Models
{
    public class Cart:List<Cart_Details>
    {
        public int Total { get; set; }
        public Cart()
        {
            Item news = new Item();

        }

    }
}
