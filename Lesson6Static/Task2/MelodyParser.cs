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
                            notes[i] = newNote.createNote();
                            break;
                        }
                    case '1':
                        {
                            newNote = new CreateRe();
                            notes[i] = newNote.createNote();
                            break;

                        }
                    case '2':
                        {
                            newNote = new CreateMi();
                            notes[i] = newNote.createNote();
                            break;
                        }
                    case '3':
                        {
                            newNote = new CreateFa();
                            notes[i] = newNote.createNote();
                            break;
                        }
                    case '4':
                        {
                            newNote = new CreateSol();
                            notes[i] = newNote.createNote();
                            break;
                        }
                    case '5':
                        {
                            newNote = new CreateLa();
                            notes[i] = newNote.createNote();
                            break;
                        }
                    case '6':
                        {
                            newNote = new CreateTi();
                            notes[i] = newNote.createNote();
                            break;
                        }
                    case '7':
                        {
                            newNote = new CreateDo();
                            notes[i] = newNote.createNote();
                            break;
                        }
                    case '8':
                        {
                            newNote = new CreateRe();
                            notes[i] = newNote.createNote();
                            break;
                        }
                    case '9':
                        {
                            newNote = new CreateMi();
                            notes[i] = newNote.createNote();
                            break;
                        }
                    default:
                        {
                            newNote = new CreatePause();
                            notes[i] = newNote.createNote();
                            break;
                        }
                }
            }
            return notes;
        }
    }
}
