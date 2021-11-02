using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class AbstractHandler
    {
        public abstract void Open(string name);
        public abstract void Create(string name);
        public abstract void Change(string name);
        public abstract void Save(string name);

    }
}
