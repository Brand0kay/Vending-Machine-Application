using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string SlotID { get; set; }
        public string FoodType { get; }

        public Item(string name, decimal price, string slotID, string foodType)
        {
            this.Name = name;
            this.Price = price;
            this.SlotID = slotID;
            this.FoodType = foodType;
            this.Quantity = 5;
        }
    }
}
