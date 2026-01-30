using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FoodStorApp
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Supplier { get; set; }
        public string Manufacture{ get; set; }
        public string ExpiryDate{ get; set; }
        public string Description { get; set; }
        public Product(string name, decimal price, string supplier, string manufacture, string expiryDate, string description)
        {
            Name = name;
            Price = price;
            Supplier = supplier;
            Manufacture = manufacture;
            ExpiryDate = expiryDate;
            Description = $"Цена: {price} руб.\nПоставщик: {supplier}\nПроизводитель: {manufacture}\nСрок годности: {expiryDate}";
        }
        public override string ToSrting()
        {
            return $"{Name} - {price}руб.";
        }
    }
}
