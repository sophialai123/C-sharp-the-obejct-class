namespace TheObjectClass
{
    class Book
    {
        public string Author { get; private set; }

        public string Title { get; private set; }

        public Book(string author = "Unknown", string title = "Untitled")
        {
            Author = author;
            Title = title;
        }

        public virtual string Stringify()
        {
            return "This is a Book object!";
        }

        //define an override ToString() method for the Book class.
        public override string ToString()
        {
            return $"This New {Author} and New {Title}.";
        }
    }
}
