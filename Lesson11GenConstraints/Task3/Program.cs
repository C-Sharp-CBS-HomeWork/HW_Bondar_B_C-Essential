using System;

namespace Task3
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        int pairsExist = 0;
        public MyDictionary(int capacity)
        {
            keys = new TKey[capacity];
            values = new TValue[capacity];
        }
        public void AddPair(TKey key, TValue value)
        {
            if (pairsExist >= keys.Length || pairsExist >= values.Length)
            {
                Console.WriteLine($"{key} and {value} cant be added! Array is full!");
            }
            else
            {
                keys[pairsExist] = key;
                values[pairsExist] = value;
                pairsExist++;
            }
        }
        public (TKey, TValue) this[int index]
        {
            get
            {
                if (index >= 0 && index < keys.Length && index < values.Length)
                    return (keys[index], values[index]);
                else
                    Console.WriteLine("Array out-of-bounds!");
                return default;
            }
        }
        //Новый индексатор на поиск по значению
        public (TKey, TValue) this [TKey index]
        {
            get
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i].Equals(index))
                        return (keys[i], values[i]);
                    else if (values[i].Equals(index))
                        return (keys[i], values[i]);
                }
                Console.WriteLine($"{index} - element not found in array!");
                return default;
            }
        }
        public int PairCount
        {
            get
            {
                return pairsExist;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> test = new MyDictionary<string, string>(5);
            test.AddPair("один", "one");
            test.AddPair("два", "two");
            test.AddPair("три", "three");
            test.AddPair("четыре", "four");
            test.AddPair("пять", "five");
            test.AddPair("шесть", "six");

            Console.WriteLine($"\nTotal number of elements: {test.PairCount}");

            Console.WriteLine(test[0]);
            Console.WriteLine(test[4]);

            Console.WriteLine(test[-1]);
            Console.WriteLine(test[5]);

            //Проверка нового индексатора
            Console.WriteLine("\nNew indexer test:");
            Console.WriteLine(test["one"]);
            Console.WriteLine(test["два"]);
            Console.WriteLine(test["six"]);
            Console.ReadKey();
        }
    }
}
