using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Pupil
    {
        protected string name;
        public Pupil()
        { }
        public Pupil(string name)
        {
            this.name = name;
        }
        public virtual void Study()
        {
            Console.WriteLine("Должен учится");
        }
        public virtual void Read()
        {
            Console.WriteLine("Умеет читать");
        }
        public virtual void Write()
        {
            Console.WriteLine("Умеет писать");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Нужно отдыхать");
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
    class ExcellentPupil : Pupil
    {
        public ExcellentPupil(string name)
        {
            this.name = name;
        }
        public override void Study()
        {
            Console.WriteLine("Много учится");
        }
        public override void Read()
        {
            Console.WriteLine("Быстро читает");
        }
        public override void Write()
        {
            Console.WriteLine("Аккуратно пишет");
        }
        public override void Relax()
        {
            Console.WriteLine("Совсем не отдыхает");
        }
    }

    class GoodPupil : Pupil
    {
        public GoodPupil(string name)
        {
            this.name = name;
        }
        public override void Study()
        {
            Console.WriteLine("Хорошо учится");
        }
        public override void Read()
        {
            Console.WriteLine("Хорошо читает");
        }
        public override void Write()
        {
            Console.WriteLine("Хорошо пишет");
        }
        public override void Relax()
        {
            Console.WriteLine("Достаточно отдыхает");
        }
    }
    class BadPupil : Pupil
    {
        public BadPupil(string name)
        {
            this.name = name;
        }
        public override void Study()
        {
            Console.WriteLine("Совсем не учится");
        }
        public override void Read()
        {
            Console.WriteLine("Умеет читать");
        }
        public override void Write()
        {
            Console.WriteLine("Пишет с ошибками");
        }
        public override void Relax()
        {
            Console.WriteLine("Много отдыхает");
        }
    }
}
