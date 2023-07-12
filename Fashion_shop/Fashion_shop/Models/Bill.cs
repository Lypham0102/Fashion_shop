using System;

namespace Fashion_shop.Models
{
    public class Bill
    {
        public int id { get; set; }
        public DateTime Date_Time { get; set; }
        public float Total { get; set; }
        public int Staff_id  { get; set; } 
        public int Customer_id { get; set; }
        public int Voucher_id { get; set; }
        public Bill() {

        }
    }
}
