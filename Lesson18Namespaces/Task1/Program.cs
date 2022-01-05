using System;
using System.Collections.Generic;
using MyDictionaryL14T3;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // проверка подключенной библиотеки из урока 14, задание 3 (L14T3)
            MyDictionary<int, string> test = new MyDictionary<int, string>();
            Console.WriteLine("Count : " + test.Count);
            test.AddPair(1, "one");
            test.AddPair(2, "two");
            test.AddPair(3, "three");
            //test.AddPair(4, "four");


            Console.WriteLine("\n" + test.MoveNext());
            Console.WriteLine(test.Current);
            Console.WriteLine(test.MoveNext());
            Console.WriteLine(test.Current);
            Console.WriteLine(test.MoveNext());
            Console.WriteLine(test.Current);
            Console.WriteLine(test.MoveNext() + "\n");
            Console.WriteLine("Count : " + test.Count);

            foreach (KeyValuePair<int, string> item in test)
            {
                Console.WriteLine($"foreach test {item}");
            }

            Console.WriteLine("\nindexer test");
            Console.WriteLine(test[0]);
            Console.WriteLine(test[1]);
            Console.WriteLine(test[2]);
            Console.WriteLine(test[3] + "\n");

            int[] keys = test.GetKeys();
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("GetKeys() test: " + keys[i]);
            }

            string[] values = test.GetValues();
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("GetValues() test: " + values[i]);
            }


            Console.ReadKey();
        }
    }
}
