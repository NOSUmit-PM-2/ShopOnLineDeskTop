using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnLineDeskTop
{
    class Catalog
    {
        List<Product> products = new List<Product>();
        public int Count { get { return products.Count; } }
        bool descending = false;

        public Product this[int ind]
        { 
            get { return products[ind]; }
        }

        public void InitializeConstant()
        {
            products.Add(new Product("Телефон", "IPhone 17, 512 MB, 2,2 GH", 150_000));
            products.Add(new Product("Фоамиран", "5 листов, 5 мм", 200));
            products.Add(new Product("Windows", "HomeEdition, v. 11", 350_000));
        }

        public List<Product> GetAll()
        {
            return new List<Product>(products);
        }

        public List<Product> GetLowPrice()
        { 
            List<Product> temp = new List<Product>();
            foreach (Product product in products)
            {
                if (product.Price < 10000) 
                temp.Add(product);
            }
            return temp;
        }

        public List<Product> GetPhones()
        {
            List<Product> temp = new List<Product>();
            foreach (Product product in products)
            {
                if (product.Name.Contains("Телефон"))
                    temp.Add(product);
            }
            return temp;
        }

        int comparer(Product a, Product b)
        {
            if (descending)
            {
                //    if (a.Price < b.Price) return -1;
                //    if (a.Price == b.Price) return 0;
                //    return 1;
                return a.Price.CompareTo(b.Price);
            }
            else 
            {
                return b.Price.CompareTo(a.Price);
            }
        }

        public List<Product> SortByPrice()
        {
            var temp = new List<Product>(products);
            temp.Sort(comparer);
            descending = !descending;
            return temp;
        }

        public List<Product> SortByName()
        {
            var temp = new List<Product>(products);
            temp.Sort((a, b) => descending ? a.Name.CompareTo(b.Name): b.Name.CompareTo(a.Name));
            descending = !descending;
            return temp;
        }

        public Product GetById(int id)
            {
            foreach (var product in products)
                { 
                if (product.Id == id) return product;
                }
            return null;
            }
    }
}
