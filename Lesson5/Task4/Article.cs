using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Article
    {
        string itemName, shopName;
        decimal itemPrice;
        public Article(string item, string shop, decimal price)
        {
            itemName = item;
            shopName = shop;
            itemPrice = price;
        }

        public string ItemName
        {
            get
            {
                return itemName;
            }
        }
        public string ShopName
        {
            get
            {
                return shopName;
            }
        }
        public decimal ItemPrice
        {
            get
            {
                return itemPrice;
            }
        }

    }
}
