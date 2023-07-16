using System;

namespace Fashion_shop.Models
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set;}
        public string Bank { get; set;}
        public string CardNumber { get; set;}
        public DateTime Date_of_birth { get; set;}
        public int Role_id { get;}
    }
}
