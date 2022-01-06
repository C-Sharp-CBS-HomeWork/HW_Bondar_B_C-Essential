using System;

namespace Task2
{
    abstract class NoteCreator
    {
        abstract public Note CreateNote();
    }

    class CreateDo : NoteCreator
    {
        bool isPause = false;
        public override Note CreateNote()
        {
            return new Note(525, 500);
        }
    }
    class CreateRe : NoteCreator
    {
        bool isPause = false;
        public override Note CreateNote()
        {
            return new Note(590, 500);
        }
    }
    class CreateMi : NoteCreator
    {
        bool isPause = false;
        public override Note CreateNote()
        {
            return new Note(660, 500);
        }
    }
    class CreateFa : NoteCreator
    {
        bool isPause = false;
        public override Note CreateNote()
        {
            return new Note(700, 500);
        }
    }
    class CreateSol : NoteCreator
    {
        bool isPause = false;
        public override Note CreateNote()
        {
            return new Note(785, 500);
        }
    }
    class CreateLa : NoteCreator
    {
        bool isPause = false;
        public override Note CreateNote()
        {
            return new Note(880, 500);
        }
    }
    class CreateTi : NoteCreator
    {
        bool isPause = false;
        public override Note CreateNote()
        {
            return new Note(988, 500);
        }
    }
    class CreatePause : NoteCreator
    {
        bool isPause = true;
        public override Note CreateNote()
        {
            return new Note(38, 1000);
        }
    }
}
