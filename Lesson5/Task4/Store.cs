using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Store
    {
        private Article[] goods = new Article[5];
        public Store(Article A, Article B, Article C, Article D, Article E)
        {
            goods[0] = A;
            goods[1] = B;
            goods[2] = C;
            goods[3] = D;
            goods[4] = E;   
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < goods.Length; i++)
                    if (goods[i].ItemName == index)
                    {
                        return ($"Item: {goods[i].ItemName}, Shop: {goods[i].ShopName}, Price: {goods[i].ItemPrice}");
                    }
                return string.Format($"{index} - No article found");

            }
        }

        // Доступ по имени экземпляра класса ARTICLE
        /*public string this[Article index]
        {
            get
            {
                for (int i = 0; i < goods.Length; i++)
             
                    if (goods[i] == index)
                    {
                        return ($"Item: {goods[i].ItemName}, Shop: {goods[i].ShopName}, Price: {goods[i].ItemPrice}");
                    }
                    return string.Format($"{index} - No article found");
                
            }
        }*/

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < goods.Length)
                    return ($"Item: {goods[index].ItemName}, Shop: {goods[index].ShopName}, Price: {goods[index].ItemPrice}");
                else
                    return "Array out-of-bounds request";
            }
        }

    }
}
