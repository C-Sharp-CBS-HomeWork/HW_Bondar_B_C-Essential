using System;

namespace Task2
{
    class MyList<T>
    {
        T[] list = null;
        int existCounter = 0;
        public MyList(int capacity)
        {
            list = new T [capacity];
        }
        public void AddItem(T item)
        {
            if (existCounter >= list.Length)
            {
                Console.WriteLine($"{item} cant be added! Array is full!");
            }
            else
            {
                list[existCounter] = item;
                existCounter++;
            }
        }
        public T this [int index]
        {
            get
            {
                if (index >= 0 && index < list.Length)
                    return list[index];
                else
                    Console.WriteLine("Array out-of-bounds!");
                return default(T);
            }
        }
        public int Count
        {
            get
            {
                return existCounter;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> test = new MyList<string>(5);
            test.AddItem("1");
            test.AddItem("2");
            test.AddItem("3");
            test.AddItem("4");
            test.AddItem("5");
            test.AddItem("66");
            test.AddItem("77");

            Console.WriteLine($"\nTotal number of elements: {test.Count}");

            Console.WriteLine(test[0]);
            Console.WriteLine(test[1]);
            Console.WriteLine(test[2]);
            Console.WriteLine(test[3]);
            Console.WriteLine(test[4]);

            Console.WriteLine(test[5]);
            Console.WriteLine(test[-1]);
            Console.ReadKey();


        }
    }
}
