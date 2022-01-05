using System;
using Task2Base;

namespace Task2Derived
{
    class DerivedClass : BaseClass
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass libTest = new DerivedClass();
            libTest.BaseMethod();
            Console.ReadKey();
            // К public методу БАЗОВОГО класа можно получить доступ из ПРОИЗВОДНОГО класа в другой сборке.
        }
    }
}
