using System;
using MyNamespace;

namespace AdditionalTaskTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass classFromMyNamespace = new MyClass();
            classFromMyNamespace.LibraryMethod();
            Console.ReadKey();
        }
    }
}
