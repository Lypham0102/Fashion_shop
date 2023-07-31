using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Fashion_shop.Models
{
	public class Bill_Details
	{
		
		
        public int Bill_id { get; set; }
        public int id_details_item { get; set; }
        public int Total { get; set; }
		public int Count { get; set; }

	}
}

