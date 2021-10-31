using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil test = new Pupil("vasya");
            test.Study();
            ClassRoom class1 = new ClassRoom(test);
        }
    }
}
