using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string melody = "987 876 765 654 ; 543 . 432 . 321; 111, 0";
            Note[] notes = MelodyParser.ParseMelody(melody);
            Player.Play(notes);
            Console.ReadKey();
        }
    }
}
