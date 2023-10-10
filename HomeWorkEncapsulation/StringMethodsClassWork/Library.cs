namespace StringMethodsClassWork
{
    public class Library
    {
        public string Name { get; set; }
        public Book[] Books = Array.Empty<Book>();

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[^1] = book;
        }

        public Book[] SearchBooks(string name)
        {
            Book[] wantedBooks = Array.Empty<Book>();
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name.ToLower() == name.ToLower()) //Books[i].Name.ToLower().Contains(name.ToLower()) ->> bu formada yazdiqda,
                                                               //gonderilen deyer kitab adlarinin icerisinde varsa onu da elave edir.
                                                               //Meselen, test gonderilib, TEst324'un icerisinde var deye onu da wantedBooks arrayine
                                                               //elave edecek.
                {
                    Array.Resize(ref wantedBooks, wantedBooks.Length + 1);
                    wantedBooks[^1] = Books[i];
                }
            }

            return wantedBooks;
        }

        public void ShowAllBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine($"{book.Name} - {book.Price}");
            }
        }
    }
}
