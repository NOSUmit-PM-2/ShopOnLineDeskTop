using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnLineDeskTop
{
    class BasketItem
    {
        public Product product { get; set; }
        public int count { get; set; }

        public BasketItem(Product product, int count = 1)
        {
            this.product = product;
            this.count = count;
        }

        public string[] ToArray()
        {
            return new string[] { product.Name, count.ToString() };
        }
    }

    class Basket
    {
        List<BasketItem> listBasketItem = new List<BasketItem>();

        public void Add(Product product)
        {
            listBasketItem.Add(new BasketItem(product));
        }

    }
}
