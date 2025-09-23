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

        public void InitializeConstant()
        {
            products.Add(new Product("Телефон", "IPhone 17, 512 MB, 2,2 GH", 150_000));
            products.Add(new Product("Фоамиран", "5 листов, 5 мм", 200));
            products.Add(new Product("Windows", "HomeEdition, v. 11", 350_000));
        }

        public List<Product> GetAll()
        { 
            return products;
        }
    }
}
