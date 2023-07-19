using System.Collections.Generic;

namespace Fashion_shop.Models
{
    public class Size
    {
        public int id { get; set; }
        public string Name { get; set; }

        // Navigation property for Item_Details
        public List<Item_Details> Item_Details { get; set; }
    }
}
