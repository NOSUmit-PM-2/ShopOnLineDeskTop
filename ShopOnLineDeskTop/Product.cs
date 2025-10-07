using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnLineDeskTop
{
    public class Product
    {
        static int countProduct = 0;
        //public readonly int Id;
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(string name, string description, decimal price)
        {
            Id = countProduct++;
            this.Name = name;
            this.Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"Продукт {Id} {Name} ({Description}) - {Price}";
        }

        public string[] ToArray()
        {
            return new string[] { Id.ToString(), Name, Description, Price.ToString() };
        }
    }
}
