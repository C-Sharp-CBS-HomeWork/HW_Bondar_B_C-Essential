using System;

namespace Task2
{
    class DOCHandler : AbstractHandler
    {
        public override void Open(string name)
        {
            Console.WriteLine($"Open file as {name}.doc");
        }
        public override void Change(string name)
        {
            Console.WriteLine($"{name}.doc changed");
        }
        public override void Create(string name)
        {
            Console.WriteLine($"New {name}.doc file created");
        }
        public override void Save(string name)
        {
            Console.WriteLine($"Saved as {name}.doc");
        }
    }
}
