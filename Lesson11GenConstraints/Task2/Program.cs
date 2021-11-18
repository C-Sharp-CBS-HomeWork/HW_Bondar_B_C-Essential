using System;

namespace Task2
{
    class CarCollection<T> where T : class
    {
        T[] collection;
        int counter = 0;
        public CarCollection(int size)
        {
            collection = new T[size];
        }

        public void AddModel(T model)
        {
            if (counter >= collection.Length)
                Console.WriteLine($"{model} cant be added! Collection is full!");
            else
            {
                collection[counter] = model;
                counter++;
            }
        }
        public int CollectionCount
        {
            get
            {
                return counter;
            }
        }
        public T this [int index]
        {
            get
            {
                if (index >= 0 && index < collection.Length)
                    return collection[index];
                else
                    Console.Write("Array out-of-bounds!");
                return default;
            }
        }
        public void ClearCollection()
        {
            for (int i = 0; i < collection.Length; i++)
            {
                collection[i] = default;
            }
            counter = default;
        }

    }
    public class Car
    {
        string make;
        int productionYear;
        public Car(string make, int year)
        {
            this.make = make;
            this.productionYear = year;
        }
        public string Make
        {
            get
            {
                return make;
            }
        }
        public int ProductionYear
        {
            get
            {
                return productionYear;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<string> test = new CarCollection<string>(3);
            test.AddModel("Mercedes");
            test.AddModel("BMW");
            test.AddModel("Audi");
            test.AddModel("Porsche");

            Console.WriteLine(test[0]);
            Console.WriteLine(test[1]);
            Console.WriteLine(test[2]);
            Console.WriteLine(test[3]);
            Console.WriteLine($"Collection size: {test.CollectionCount}");

            Console.WriteLine("\nClearCollection() test\n" + new string('-',30));
            
            // Проверка метода ClearCollection()
            test.ClearCollection();
            Console.WriteLine($"Collection size: {test.CollectionCount}");
            Console.WriteLine(test[0]);
            Console.WriteLine(test[1]);
            Console.WriteLine(test[3]);

            // Проверка работы класса как Типа в дженерике
            Console.WriteLine("\nПроверка типа в класса в дженерике\n" + new string('-',30));
            CarCollection<Car> testClass = new CarCollection<Car>(2);
            Car car1 = new Car("Ferrari", 2020);
            Car car2 = new Car("Lamborghini", 2021);
            testClass.AddModel(car1);
            testClass.AddModel(car2);
            Console.WriteLine($"Collection size: {testClass.CollectionCount}");
            Console.WriteLine(testClass[0].Make + ' ' + testClass[0].ProductionYear);
            Console.WriteLine(testClass[2]);

            testClass.ClearCollection();
            Console.WriteLine($"\nCollection size: {testClass.CollectionCount}");
            Console.ReadKey();

        }
    }
}
