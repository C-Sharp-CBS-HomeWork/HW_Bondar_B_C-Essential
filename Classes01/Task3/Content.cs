using System;

namespace Task3
{
    class Content
    {
        readonly string content;
        public Content(string content)
        {
            this.content = content;
        }

        /*
        public string ContentName
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Здесь пусто :(";
            }
            set
            {
                content = value;
            }
        }
        */
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(content);
            Console.ResetColor();
        }
    }
}
