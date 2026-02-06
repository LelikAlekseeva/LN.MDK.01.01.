using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodProducts
{
    public class Product
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Supplier { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }

        public Product(string category, string name, decimal price, string supplier)
        {
            Category = category;
            Name = name;
            Price = price;
            Supplier = supplier;
            Quantity = 1;
        }

        public string GetOrderInfo()
        {
            return $"{Name} - {Quantity} шт. × {Price} руб. = {Price * Quantity} руб.";
        }
    }
}
