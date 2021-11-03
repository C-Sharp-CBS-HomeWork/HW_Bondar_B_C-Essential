namespace Task2
{
    abstract class AbstractHandler
    {
        public abstract void Open(string name);
        public abstract void Create(string name);
        public abstract void Change(string name);
        public abstract void Save(string name);

    }
}
