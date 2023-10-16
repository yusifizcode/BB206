using Abstractions.Models;

namespace Abstractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book book = new Book();
            book.Name = "Melikmemmed";
            book.Author = "Xalq";
            book.Price = 5;
            book.Genre = "Dehshet";

            Journal journal = new Journal();
            journal.Name = "Molla Nesreddin";
            journal.CompanyName = "Molla Production";
            journal.Price = 10;

            library.AddProduct(book);
            library.AddProduct(journal);

            Product[] arr = library.GetProductsByPrice(1, 12);

            foreach (Product product in arr)
            {
                Console.WriteLine(product.GetInfo());
            }

            Employee employee = new Employee();
            employee.SalaryOfHour = 10;
            employee.WorkingHour = 210;
        }
    }
}