using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil test = new Pupil("basic");
            test.Study();
            
            ExcellentPupil test1 = new ExcellentPupil("excellent");
            Console.WriteLine("\n" + test1.Name);
            test1.Study();
            test1.Read();
            test1.Write();
            test1.Relax();

            GoodPupil test2 = new GoodPupil("good");
            Console.WriteLine("\n" + test2.Name);
            test2.Study();
            test2.Read();
            test2.Write();
            test2.Relax();

            BadPupil test3 = new BadPupil("bad");
            Console.WriteLine("\n" + test3.Name);
            test3.Study();
            test3.Read();
            test3.Write();
            test3.Relax();

            Console.WriteLine("\nПроверка ClassRoom:");
            ClassRoom class1= new ClassRoom(test, test1, test2, test3);
            class1.Stats();

            Console.ReadKey();

        }
    }
}
