using System;

namespace Task3
{
    struct Price
    {
        string itemName, shopName;
        decimal price;
        public Price (string item, string shop, decimal price)
        {
            itemName = item;
            shopName = shop;
            this.price = price;
        }

        public string ItemName
        {
            get { return itemName; }
        }
        public string ShopName
        {
            get { return shopName; }
        }
        public decimal ItmPrice { get { return price; } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Price[] goods = new Price[2];
            for (int i = 0; i < goods.Length; i++)
            {
                Console.Write("Enter item name: ");
                string item = Console.ReadLine();
                Console.Write("Enter shop name: ");
                string shop = Console.ReadLine();
                decimal price;
                while (true)
                {
                    Console.Write("Enter price: ");
                    string inputPrice = Console.ReadLine();
                    
                    if (!Decimal.TryParse(inputPrice, out price))
                    {
                        Console.WriteLine("Wrong price format! Please, use only digits");
                    }
                    else
                    {
                        break;
                    }
                }
                goods[i] = new Price(item, shop, price);
            }

            Array.Sort(goods, new Comparison<Price>((a, b) => a.ShopName.CompareTo(b.ShopName)));

            while (true)
            {
                Console.Write("Enter shop name: ");
                string shopSearch = Console.ReadLine();
                try
                {
                    bool shopFound = false;
                    for (int i = 0; i < goods.Length; i++)
                    {
                        if (shopSearch == goods[i].ShopName)
                        {
                            Console.WriteLine($"Item: {goods[i].ItemName} / Price: {goods[i].ItmPrice} USD");
                            shopFound = true;
                        }
                    }
                    if (!shopFound)
                    {
                        throw new Exception($"Shop {shopSearch} not found.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
