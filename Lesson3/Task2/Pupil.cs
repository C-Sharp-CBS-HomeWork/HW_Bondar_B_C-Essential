using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Pupil
    {
        string name;

        public Pupil(string name)
        {
            this.name = name;
        }
        public void Study()
        {
            Console.WriteLine("Должен учится");
        }
        public void Read()
        {
            Console.WriteLine("Умеет читать");
        }
        public void Write()
        {
            Console.WriteLine("Умеет писать");
        }
        public void Relax()
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
        string name;
        public ExcellentPupil(string name)
        {
            this.name = name;
        }
        public void Study()
        {
            Console.WriteLine("Много учится");
        }
        public void Read()
        {
            Console.WriteLine("Быстро читает");
        }
        public void Write()
        {
            Console.WriteLine("Аккуратно пишет");
        }
        public void Relax()
        {
            Console.WriteLine("Совсем не отдыхает");
        }
    }

    class GoodPupil : Pupil
    {
        GoodPupil() { }
        void Study()
        {
            Console.WriteLine("Хорошо учится");
        }
        void Read()
        {
            Console.WriteLine("Хорошо читает");
        }
        void Write()
        {
            Console.WriteLine("Хорошо пишет");
        }
        void Relax()
        {
            Console.WriteLine("Достаточно отдыхает");
        }
    }
    class BadPupil : Pupil
    {
        BadPupil() { }
        void Study()
        {
            Console.WriteLine("Совсем не учится");
        }
        void Read()
        {
            Console.WriteLine("Умеет читать");
        }
        void Write()
        {
            Console.WriteLine("Пишет с ошибками");
        }
        void Relax()
        {
            Console.WriteLine("Много отдыхает");
        }
    }
}
