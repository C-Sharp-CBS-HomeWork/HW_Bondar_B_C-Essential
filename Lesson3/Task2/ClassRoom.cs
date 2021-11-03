using System;

namespace Task2
{
    class ClassRoom
    {
        Pupil[] pupils;
        public ClassRoom(Pupil A, Pupil B, Pupil C, Pupil D)
        {
            pupils = new Pupil [4] { A, B, C, D};
        }

        public ClassRoom(Pupil A, Pupil B, Pupil C)
        {
            pupils = new Pupil[3] { A, B, C };
        }

        public ClassRoom(Pupil A, Pupil B)
        {
            pupils = new Pupil[2] { A, B };
        }

        public void Stats()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine(pupils[i].Name);
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
                Console.WriteLine();
            }

        }
    }
}
