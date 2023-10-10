namespace StringMethodsClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Name = "TEst";
            book.Price = 10;

            Book book1 = new Book();
            book1.Name = "Test";
            book1.Price = 20;

            Book book2 = new Book();
            book2.Name = "Test2";
            book2.Price = 30;

            Library library = new Library();
            library.Name = "Axundov";

            library.AddBook(book);
            library.AddBook(book1);
            library.AddBook(book2);

            library.ShowAllBooks();
            //Book wantedBook = library.SearchBook("asdasd");
            //if (wantedBook != null)
            //{
            //    Console.WriteLine(wantedBook.Name);
            //}
            //else
            //{
            //    Console.WriteLine("Bele bir kitab yoxdur!");
            //}

            Book[] books = library.SearchBooks("TEST");

            foreach (Book wantedBook in books)
            {
                Console.WriteLine(wantedBook.Name);
            }

        }
    }
}