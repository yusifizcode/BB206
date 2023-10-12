using ConsoleAppTask.Models;

namespace ConsoleAppTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book book1 = new Book(1, "Dracula", "Qorxu", 12);
            //Book book2 = new Book(2, "Cont", "Action", 34);
            //Book book3 = new Book(3, "Navi", "Qorxu", 34);


            //Library library = new Library();

            //library.AddBook(book1);
            //library.AddBook(book2);
            //library.AddBook(book3);

            //library.ShowAllBook();


            //foreach (Book book in library.GetFilteredBooks("acTIon"))
            //{
            //    book.ShowInfo();
            //}

            //foreach (Book book in library.GetFilteredBooks(5,15))
            //{
            //    book.ShowInfo();
            //}



            //Console.Write("Enter book name: ");
            //string name = Console.ReadLine();

            //Console.Write("\nEnter book genre: ");
            //string genre = Console.ReadLine();

            //string noStr;
            //int no;

            //do
            //{
            //    Console.Write("\nEnter book no: ");
            //    noStr = Console.ReadLine();
            //} while (!int.TryParse(noStr, out no));

            //double bookPrice;
            //string priceStr;

            //do
            //{
            //    Console.Write("\nEnter book price:");
            //    priceStr = Console.ReadLine();

            //} while (!double.TryParse(priceStr, out bookPrice));


            //Book book = new Book(no, name, genre, bookPrice);

            //book.ShowInfo();


            Library library = new Library();

            int choice;
            do
            {
                Console.WriteLine("\nChoose operation");
                Console.WriteLine("1. Kitab Yarat ve kitabxanaya elave et" +
                    "\n2. Butun kitablari goster" +
                    "\n3. Kitab infosu" +
                    "\n4. Kitabi silin" +
                    "\n0. Proqrami bitir");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //Book book = CreateBook();
                        library.AddBook(CreateBook());
                        break;
                    case 2:
                        library.ShowAllBook();

                        break;
                    case 3:
                        Console.Write("Bir nomre daxil edin");
                        int nomre = int.Parse(Console.ReadLine());
                        Console.WriteLine("Book infosu");
                        library.ShowBook(nomre);
                        break;
                    case 4:
                        Console.Write("Bir nomre daxil edin");
                        int no = int.Parse(Console.ReadLine());
                        library.RemoveBook(no);
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
        }

        public static Book CreateBook()
        {
            Book book = null;
            Console.Write("Enter book No: ");
            int no = int.Parse(Console.ReadLine());

            Console.Write("Enter book name: ");
            string name = Console.ReadLine();

            Console.Write("\nEnter book genre: ");
            string genre = Console.ReadLine();


            double bookPrice;
            string priceStr;

            do
            {
                Console.Write("\nEnter book price:");
                priceStr = Console.ReadLine();

            } while (!double.TryParse(priceStr, out bookPrice));


            book = new Book(no, name, genre, bookPrice);
            return book;

        }
    }

}