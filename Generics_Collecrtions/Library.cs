namespace Generics_Collections
{
    public class Library
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Journal> Journals { get; set; } = new List<Journal>();

        public void ShowBookName()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book.Name);
            }
        }

        public void FindByName(string name)
        {
            foreach (var book in Books)
            {
                if (book.Name == name)
                    Console.WriteLine(book.Name);
            }
        }


    }

    public class Book
    {
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public int PageCount { get; set; }
        public Genre Genre { get; set; }
    }

    public class Journal
    {
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public int PageCount { get; set; }
        public Genre Genre { get; set; }
    }

    public enum Genre : byte
    {
        Fiction = 1,
        Novel = 2,
        Fantasy = 3,
        Science = 4
    }

}
