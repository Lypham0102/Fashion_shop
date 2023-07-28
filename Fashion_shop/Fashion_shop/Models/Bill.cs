using System;
using System.Diagnostics.CodeAnalysis;

namespace Fashion_shop.Models
{
    public class Bill
    {
        public int id { get; set; }
        [AllowNull]
        public DateTime Date { get; set; }
        //[AllowNull]
        //public DateTime Time { get; set; }
        public float Total { get; set; }

        [AllowNull]
        public int Voucher_id { get; set; }
        public int Status { get; set; }

        [AllowNull]
        public int User_id { get; set; }
        public Bill() {

        }
    }
}
