using System;

namespace Task4
{
    class MyArrayList
    {
        int counter = 0;
        object[] list = null;
        public MyArrayList (int capacity)
        {
            list = new object [capacity];
        }
        public void Add(object item)
        {
            if(counter < list.Length)
            {
                list[counter] = item;
                counter++;
            }
            else
            {
                Console.WriteLine($"{item.ToString()} cant be added! Array is full!");
            }
        }
        public int Count
        {
            get
            {
                return counter;
            }
        }
        public object this [int index]
        {
            get
            {
                if (index >= 0 && index < list.Length)
                    return list[index];
                else
                    Console.WriteLine("Array out-of-bounds");
                return default;
            }
        }
        public void Clear()
        {
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = default;
            }
            counter = default;
        }
        public bool IsArrayElement(object item)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Equals(item))
                    return true;
            }
                    return false;
        }
    }
    class TestClass
    {
        int x = 1;
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            TestClass testClass2 = new TestClass();
            MyArrayList test = new MyArrayList(3);
            test.Add(5);
            test.Add("some text");
            test.Add(testClass);
            Console.WriteLine($"Array current capacity: {test.Count}");
            test.Add(4);
            test.Add(testClass2);

            Console.WriteLine("\nIndexer test:");
            Console.WriteLine(test[0]);
            Console.WriteLine(test[1]);
            Console.WriteLine(test[2]);
            Console.WriteLine("\nIndex that not exist:");
            Console.WriteLine(test[3]);
            Console.WriteLine(test[-1]);

            int x = (int)test[0];
            Console.WriteLine($"Unboxing from array: {x}");

            Console.WriteLine($"\nIsArrayElement() method test:");
            Console.WriteLine(test.IsArrayElement(5));
            Console.WriteLine(test.IsArrayElement("5"));
            Console.WriteLine(test.IsArrayElement(testClass2));

            test.Clear();
            Console.WriteLine($"\nArray after Clear() method: {test.Count}");
            Console.WriteLine($"Element 1:{test[0]}");
            Console.WriteLine($"Element 2:{test[1]}");
            Console.WriteLine($"Element 3:{test[2]}");
            Console.WriteLine(test[3]);
            Console.ReadKey();
        }
    }
}
