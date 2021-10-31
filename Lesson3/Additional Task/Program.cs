using System;

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterGreen derived = new PrinterGreen();
            derived.Print("наследник");

            Printer testUp = derived;
            testUp.Print("upcast - приведение к базовому");

            PrinterGreen testDown = (PrinterGreen)testUp;
            testDown.Print("downcast - приведение к классу наследнику");
            Console.ReadKey();
        }
    }
}
