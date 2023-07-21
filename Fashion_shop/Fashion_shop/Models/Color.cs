using System;
using System.Collections.Generic;

namespace Fashion_shop.Models
{
    public class Color { 
        public int id { get; set; }
        public string Name { get; set; }

        public List<Item_Details> Item_Details { get; set; }
    }
}
