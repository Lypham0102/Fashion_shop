namespace Fashion_shop.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public bool IsAdmin { get; set; }
        public int UserId { get; set; }
    }
}
