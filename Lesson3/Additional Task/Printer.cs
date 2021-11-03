using System;

namespace Additional_Task
{
    class Printer
    {
        public void Print (string value)
        {
            Console.WriteLine(value);
        }
    }

    class PrinterGreen : Printer
    {
        public void Print (string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
