using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnLineDeskTop
{
    public class BasketItem
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
            return new string[] {product.Id.ToString(), product.Name, product.Price.ToString(), count.ToString() };
        }
    }

    public class Basket
    {
        List<BasketItem> listBasketItem = new List<BasketItem>();

        public void Add(Product product)
        {
            listBasketItem.Add(new BasketItem(product));
        }

        public List<BasketItem> GetAll()
        {
            return new List<BasketItem>(listBasketItem);
        }

        public BasketItem GetById(int id)
        {
            foreach (var item in listBasketItem)
            {
                if (item.product.Id == id) return item;
            }
            return null;
        }

    }
}
