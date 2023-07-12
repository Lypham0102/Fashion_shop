namespace Fashion_shop.Models
{
    public class Item
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }
        public string Gender { get; set; }
        public int Count { get; set; }
        public string Size { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        public int Materials_id { get; set; }
        public int User_Item_Id { get; set; }
        public int Product_Type_Id { get; set; }
        //public Item(Item item)
        //{
        //    this.id = item.id;
        //    this.Name = item.Name;
        //    this.Image = item.Image;
        //    this.Brand = item.Brand;
        //    this.Color = item.Color;
        //    this.Price = item.Price;
        //    this.Gender = item.Gender;
        //    this.Count = item.Count;
        //    this.Size = item.Size;
        //    this.Country = item.Country;
        //    this.Materials_id = item.Materials_id;
        //    this.User_Item_Id = item.User_Item_Id;
        //    this.Product_Type_Id = item.Product_Type_Id;
        //}
    }
}
