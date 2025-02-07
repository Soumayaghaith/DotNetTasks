namespace A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>() 
            {
                new Book ("1", "Book1", new string[] { "Ahmed", "Mohamed"}, new DateTime(2025,5,11), 250),
                new Book ("2", "Book2", new string[] { "Sarah", "Moataz"}, new DateTime(2022,1,11), 150),
                new Book ("3", "Book3", new string[] { "Ayman", "Magdy"}, new DateTime(2021,3,11), 50)

            };
            MyDelegate getTitle = BookFunctions.GetTitle;
            Func<Book,String> func01 = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, getTitle);
            //using anonymous methods
            LibraryEngine.ProcessBooks(books, delegate(Book b) { return b.Title; });
            //using lambda expression
            LibraryEngine.ProcessBooks(books, b =>  b.Title);

            MyDelegate getAuthors = BookFunctions.GetAuthors;
            Func<Book, String> func02 = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, getAuthors);
            
            //using anonymous methods
            LibraryEngine.ProcessBooks(books, delegate (Book b) { return string.Join(",", b.Authors); });
            //using lambda expression
            LibraryEngine.ProcessBooks(books, b => string.Join(",", b.Authors));


            MyDelegate getPrice = BookFunctions.GetPrice;
            Func<Book, String> func03 = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks(books, getPrice);
            //using anonymous methods
            LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.Price.ToString(); });
            //using lambda expression
            LibraryEngine.ProcessBooks(books, b => b.Price.ToString());


        }
    }
}
