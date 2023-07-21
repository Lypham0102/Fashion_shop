using System.ComponentModel.DataAnnotations;
namespace Fashion_shop.Models
{
	public class Bill_Details
	{
		[Key]
		public int id_Bill_Details { get; set; }
		public int Bill_id { get; set; }
		public int Total { get; set; }
		public int Count { get; set; }

	}
}

