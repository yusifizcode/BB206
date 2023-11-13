using EFCore_Task.Concretes;
using EFCore_Task.Models;

namespace EFCore_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();
            movie.Name = "Test123";
            movie.Genre = "TestGenre123";
            movie.DirectorId = 100123;

            MovieService movieService = new MovieService();
            //movieService.Create(movie);

            //foreach (var item in movieService.GetAll())
            //{
            //    Console.WriteLine(item.Name);
            //}
            //movieService.Delete(2);
            Console.WriteLine(movieService.GetById(2)?.Name);
        }
    }
}