using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ClassRoom
    {
        Pupil[] pupils;
        ClassRoom(Pupil A, Pupil B, Pupil C, Pupil D)
        {
            pupils = new Pupil [4] { A, B, C, D};
        }

        ClassRoom(Pupil A, Pupil B, Pupil C)
        {
            pupils = new Pupil[3] { A, B, C };
        }

        ClassRoom(Pupil A, Pupil B)
        {
            pupils = new Pupil[2] { A, B };
        }
    }
}
