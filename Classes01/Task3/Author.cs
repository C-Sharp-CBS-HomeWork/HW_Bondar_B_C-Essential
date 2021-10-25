using System;

namespace Task3
{
    class Author
    {
        readonly string author;
        public Author(string author)
        {
            this.author = author;
        }
        /*
        public string AuthorName
        {
            get
            {
                if (author != null)
                    return author;
                else
                    return "Здесь пусто";
            }
            set
            {
                author = value;
            }
        }
        */

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(author);
            Console.ResetColor();
        }
    }
}
