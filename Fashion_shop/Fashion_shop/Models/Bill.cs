using System;

namespace Fashion_shop.Models
{
    public class Bill
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public float Total { get; set; }
        public int Voucher_id { get; set; }
        public string Status { get; set; }
        public int User_id { get; set; }
        public Bill() {

        }
    }
}
