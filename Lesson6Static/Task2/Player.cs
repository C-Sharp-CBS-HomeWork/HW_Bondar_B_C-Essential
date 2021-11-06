using System;

namespace Task2
{
    static class Player
    {
        public static void Play(Note[] notes)
        {
            for (int i = 0; i < notes.Length; i++)
            {
                Console.Beep(notes[i].Frequency, notes[i].Duration);
            }
        }
    }
}
