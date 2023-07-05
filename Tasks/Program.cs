namespace Tasks
{
    public class Library
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int EmployeeCount { get; set; }
        public int BookCount
        {
            get
            {
                return Books.Count;
            }
        }
        public int JournalCount
        {
            get
            {
                return Journals.Count;
            }
        }
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Journal> Journals { get; set; } = new List<Journal>();

        public void ShowBooksNames()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book.Name);
            }
        }

        public void ShowJournalsNames()
        {
            foreach (var journal in Journals)
            {
                Console.WriteLine(journal.Name);
            }
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddJournal(Journal journal)
        {
            Journals.Add(journal);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }

        public void RemoveJournal(Journal journal)
        {
            Journals.Remove(journal);
        }

        public List<Book> SearchByAuthor(string author)
        {
            var bookList = new List<Book>();

            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Author.Equals(author))
                    bookList.Add(Books[i]);
            }

            return bookList;
        }
    }

    public class Publication
    {
        public string Name { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public int SheetCount { get; set; }
    }

    public class Book : Publication
    {
        public BookGenre Genre { get; set; }
    }

    public class Journal : Publication
    {
        public JournalGenre Genre { get; set; }
    }

    public enum BookGenre : byte
    {
        Fantasy = 1,
        Science = 2,
        Fictions = 3,
        Roman = 4,
        Horror = 5
    }

    public enum JournalGenre : byte
    {
        Journalistic = 1,
        Science = 2,
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library()
            {
                Name = "Axundov adına kitabxana",
                Address = "Near the Sahil m.",
                EmployeeCount = 150
            };

            Book book1 = new Book()
            {
                Name = "Martin Iden",
                Author = "Cek London",
                SheetCount = 280,
                Genre = BookGenre.Roman,
                ReleaseDate = DateTime.Parse("12.21.1912")
            };

            Book book2 = new Book()
            {
                Name = "The Brothers Karamazov",
                Author = "Fyodor Dostoevsky",
                SheetCount = 300,
                Genre = BookGenre.Horror,
                ReleaseDate = DateTime.Parse("01.21.1876")
            };

            Book book4 = new Book()
            {
                Name = "Crime and Punishment",
                Author = "Fyodor Dostoevsky",
                SheetCount = 900,
                Genre = BookGenre.Roman,
                ReleaseDate = DateTime.Parse("01.21.1866")
            };

            Book book3 = new Book()
            {
                Name = "Xemse",
                Author = "Nizami Gencevi",
                SheetCount = 1500,
                Genre = BookGenre.Roman,
                ReleaseDate = DateTime.Parse("11.30.1200")
            };

            Journal journal1 = new Journal()
            {
                Name = "Kirpi",
                Author = "Celil Memmedquluzade",
                SheetCount = 20,
                Genre = JournalGenre.Journalistic,
                ReleaseDate = DateTime.Parse("07.21.1766")
            };

            Journal journal2 = new Journal()
            {
                Name = "Microsoft",
                Author = "Jef Bezos",
                SheetCount = 50,
                Genre = JournalGenre.Science,
                ReleaseDate = DateTime.Parse("11.30.2023")
            };

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            library.AddJournal(journal1);
            library.AddJournal(journal2);

            //Console.WriteLine("Books");
            //Console.WriteLine("=====================");
            //library.ShowBooksNames();

            //Console.WriteLine();

            //Console.WriteLine("Journals");
            //Console.WriteLine("=====================");
            //library.ShowJournalsNames();


            var filteredList = library.SearchByAuthor("Fyodor Dostoevsky");

            foreach (var book in filteredList)
            {
                Console.WriteLine(book.Name);
            }
        }
    }
}