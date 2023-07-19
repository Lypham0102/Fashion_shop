using System;

namespace Fashion_shop.Models
{
    public enum Role
    {
        Admin = 1,
        User = 0,
        
        Unauthorized = 2
    }
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
        public string Username { get; set; }
        public DateTime Date_of_birth { get; set;}
        public Role Role_id { get; set; }
    }
}
