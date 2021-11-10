using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Alternative
{
    class Print
    {
        public static void Printer(string stroka, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}
