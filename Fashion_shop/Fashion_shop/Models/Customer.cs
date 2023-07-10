using Microsoft.VisualBasic;
using System;

namespace Fashion_shop.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber{ get; set; }
        public DateTime Day_of_birth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public Customer()
        {

        }

    }
}
