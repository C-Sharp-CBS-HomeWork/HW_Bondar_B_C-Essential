using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Старт воспроизведения");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Воспроизведение приостановлено");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Воспроизведение прервано");
        }
        public void Record()
        {
            Console.WriteLine("Производится запись");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("Запись приостановлена");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Запись прервана");
        }
    }
}
