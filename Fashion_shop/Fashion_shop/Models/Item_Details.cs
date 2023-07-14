using System;
using System.ComponentModel.DataAnnotations;

namespace Fashion_shop.Models
{
	public class Item_Details
	{
		[Key]
		public int id_details_item { get; set; }
		public int Item_id { get; set; }
		public int Size_id { get; set; }
		public int Color_id { get; set; }

    }
}

