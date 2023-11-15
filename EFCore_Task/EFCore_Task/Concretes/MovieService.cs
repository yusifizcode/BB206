using EFCore_Task.Abstractions;
using EFCore_Task.DataAccessLayer;
using EFCore_Task.Models;

namespace EFCore_Task.Concretes
{
    public class MovieService : IService<Movie>
    {
        AppDbContext _context = new AppDbContext();
        public void Create(Movie entity)
        {
            if (entity != null)
            {
                _context.Movies.Add(entity);
                _context.SaveChanges();
            }

        }

        public void Delete(int? id)
        {
            if (id == null)
            {
                Console.WriteLine("Error!");
                return;
            }

            Movie existMovie = _context.Movies.Find(id);
            if (existMovie != null)
            {
                _context.Movies.Remove(existMovie);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        public List<Movie> GetAll()
        {
            List<Movie> movies = _context.Movies.ToList();
            return movies;
        }

        public Movie GetById(int? id)
        {
            var movie = _context.Movies.Find(id);

            if (id != null)
                return movie;

            return null;
        }

        public void Update(int? id, Movie entity)
        {
            if (id == null || entity == null)
            {
                Console.WriteLine("Error");
                return;
            }

            var existMovie = _context.Movies.Find(id);
            if (existMovie == null)
            {
                Console.WriteLine("Error!");
                return;
            }


            existMovie.Name = entity.Name;
            existMovie.Genre = entity.Genre;
            existMovie.DirectorId = entity.DirectorId;
            _context.SaveChanges();
        }
    }
}
