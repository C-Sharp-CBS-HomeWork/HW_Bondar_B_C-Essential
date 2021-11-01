using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Car mercedes = new Car();
            Plane boeing = new Plane();
            Ship concordia = new Ship();
            mercedes.Stats();
            Console.WriteLine("\n");
            boeing.Stats();
            Console.WriteLine("\n");
            concordia.Stats();
            Console.ReadKey();
        }
    }
}
