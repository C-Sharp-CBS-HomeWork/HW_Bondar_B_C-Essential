namespace Task3
{
    class Book
    {
        readonly Title title;
        readonly Author author;
        readonly Content content;

        public Book (string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }
    }
}
