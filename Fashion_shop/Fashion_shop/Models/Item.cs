﻿using System.Collections.Generic;

namespace Fashion_shop.Models
{
    public class Item
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public string Gender { get; set; }
        public int Count { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public int Materials_id { get; set; }
        public int User_Item_id { get; set; }
        public int Product_Type_id { get; set; }

    }
}
