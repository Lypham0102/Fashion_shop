using Microsoft.AspNetCore.Mvc;
using Fashion_shop.Models;
using Newtonsoft.Json;

namespace Fashion_shop.Controllers
{
    public class CartController : Controller
    {
        
        public IActionResult Cart()
        {
            Cart cart = JsonConvert.DeserializeObject < Cart > (Request.Cookies["Cart"]);
            return View(model:cart);
        }

        public void AddToCart()
        {
            if(Request.Cookies["Cart"] == null)
            {
                Cart cart = new Cart();
                Item item = new Item();
                Cart_Details details = new Cart_Details();
                details.item = item;
                cart.Cart_Details.Add(details);
            }
        }
    }
}
