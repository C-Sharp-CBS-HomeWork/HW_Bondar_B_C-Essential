using System;

namespace Task2
{
    class XMLHandler : AbstractHandler
    {
        public override void Open(string name)
        {
            Console.WriteLine($"Open file as {name}.xml");
        }
        public override void Change(string name)
        {
            Console.WriteLine($"{name}.xml changed");
        }
        public override void Create(string name)
        {
            Console.WriteLine($"New {name}.xml file created");
        }
        public override void Save(string name)
        {
            Console.WriteLine($"Saved as {name}.txt");
        }
    }
}
