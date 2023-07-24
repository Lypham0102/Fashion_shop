using System.Collections.Generic;

namespace Fashion_shop.Models
{
    public class Item_list
    {
        public Item item;
        public List<Color> colors;
        public List<Size> sizes;

        public Item_list(Item i, List<Color> c, List<Size> s)
        {
            item = i;
            colors = c;
            sizes = s;

        }
    }
}
