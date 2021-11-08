using System;

namespace Task2
{
    static class MelodyParser
    {
        public static Note[] ParseMelody(string melody)
        {
            NoteCreator newNote = null;
            char[] array = melody.ToCharArray();
            Note[] notes = new Note [array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                char note = array[i];
                switch (note)
                {
                    case '0':
                        {
                            newNote = new CreateDo();
                            break;
                        }
                    case '1':
                        {
                            newNote = new CreateRe();
                            break;

                        }
                    case '2':
                        {
                            newNote = new CreateMi();
                            break;
                        }
                    case '3':
                        {
                            newNote = new CreateFa();
                            break;
                        }
                    case '4':
                        {
                            newNote = new CreateSol();
                            break;
                        }
                    case '5':
                        {
                            newNote = new CreateLa();
                            break;
                        }
                    case '6':
                        {
                            newNote = new CreateTi();
                            break;
                        }
                    case '7':
                        {
                            newNote = new CreateDo();
                            break;
                        }
                    case '8':
                        {
                            newNote = new CreateRe();
                            break;
                        }
                    case '9':
                        {
                            newNote = new CreateMi();
                            break;
                        }
                    default:
                        {
                            newNote = new CreatePause();
                            break;
                        }
                }
                notes[i] = newNote.CreateNote();
            }
            return notes;
        }
    }
}
