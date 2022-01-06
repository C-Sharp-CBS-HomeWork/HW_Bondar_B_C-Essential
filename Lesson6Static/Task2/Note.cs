using System;

namespace Task2
{
    class Note
    {
        int duration, frequency;
        bool isPause;
        public Note (int frequency, int duration)
        {
            this.frequency = frequency;
            this.duration = duration;
        }

        public int Frequency
        {
            get
            {
                return frequency;
            }
        }
        public int Duration
        {
            get
            {
                return duration;
            }
        }
    }
}
