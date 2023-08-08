using System;
using System.Diagnostics.CodeAnalysis;
namespace Fashion_shop.Models
{
    public class Voucher
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End_dates { get; set; }
        public int Count { get; set; }
        public double Discount { get; set; }
    }
}
