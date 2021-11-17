using System;

namespace AdditionalTask
{
    class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
    class Test
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> test = new MyClass<int>();
            var x = MyClass<Test>.FactoryMethod();
            var y = MyClass<int>.FactoryMethod();
            Console.WriteLine(x.GetType());
            Console.WriteLine(y.GetType());
            Console.ReadKey();
        }
    }
}
