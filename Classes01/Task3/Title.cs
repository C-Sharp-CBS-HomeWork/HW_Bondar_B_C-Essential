using System;

namespace Task3
{
    class Title
    {
        readonly string title;
        public Title(string title)
        {
            this.title = title;
        }
        /*
        public string TitleName
        {
            get
            {
                if (title != null)
                    return title;
                
                else
                    return "Здесь пусто :("; 
            }
            set
            {
                title = value;
            }
        }
        */
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
            Console.ResetColor();
        }
    }
}
