using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class TXTHandler : AbstractHandler
    {
        public override void Open(string name)
        {
            Console.WriteLine($"Open file as {name}.txt");
        }
        public override void Change(string name)
        {
            Console.WriteLine($"{name}.txt changed");
        }
        public override void Create(string name)
        {
            Console.WriteLine($"New {name}.txt file created");
        }
        public override void Save(string name)
        {
            Console.WriteLine($"Saved as {name}.txt");
        }
    }
}
