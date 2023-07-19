using System;
namespace Fashion_shop.Models
{
	public class Item_Details
	{
		public int id { get; set; }
		public int Item_id { get; set; }
		public int Size_id { get; set; }
		public int Color_id { get; set; }

        // Navigation properties for the related entities
        public Item Item { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
    }
}

