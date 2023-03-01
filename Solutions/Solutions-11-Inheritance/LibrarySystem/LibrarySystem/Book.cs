namespace LibrarySystem
{
    // Books have a genre, of the following type: 
    public enum Genre
    {
        Children,
        Fiction,
        NonFiction
    }


    // A book is a kind of item.
    public class Book : Item
    {
        // Instance variables.
        private string author;
        private string isbn;
        private Genre genre;

        // Constructor.
        public Book(string title, string author, string isbn, Genre genre)
            : base(title)
        {
            this.author = author;
            this.isbn = isbn;
            this.genre = genre;
        }

        public override bool CanBeBorrowedBy(Member member)
        {
            if (genre == Genre.Children)
            {
                // Children's books can only be borrowed by children.
                return member.Age <= 16;
            }
            else
            {
                // Other books can be borrowed by anyone.
                return true;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n  Additional book details: {author} {isbn} {genre}.";
        }
    }
}
