using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
