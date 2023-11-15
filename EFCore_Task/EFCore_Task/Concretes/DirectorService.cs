using EFCore_Task.Abstractions;
using EFCore_Task.DataAccessLayer;
using EFCore_Task.Models;

namespace EFCore_Task.Concretes
{
    public class DirectorService : IService<Director>
    {
        AppDbContext _context = new AppDbContext();
        public void Create(Director entity)
        {
            if (entity == null)
            {
                Console.WriteLine("Error!");
                return;
            }

            _context.Directors.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            if (id == null)
            {
                Console.WriteLine("Error!");
                return;
            }

            var existDirector = _context.Directors.Find(id);
            if (existDirector != null)
            {
                _context.Directors.Remove(existDirector);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Directory is not found!");
                return;
            }
        }

        public List<Director> GetAll()
        {
            var directors = _context.Directors.ToList();
            return directors;
        }

        public Director GetById(int? id)
        {
            if (id == null)
            {
                Console.WriteLine("Error!");
                return null;
            }

            var existDirector = _context.Directors.Find(id);

            if (existDirector == null)
            {
                Console.WriteLine("Director is not found!");
                return null;
            }

            return existDirector;
        }

        public void Update(int? id, Director entity)
        {
            if (id == null || entity == null)
            {
                Console.WriteLine("Error!");
                return;
            }

            var existDirector = _context.Directors.Find(id);

            if (existDirector == null)
            {
                Console.WriteLine("Director is not found!");
                return;
            }

            existDirector.FullName = entity.FullName;
            existDirector.Experience = entity.Experience;
            existDirector.Age = entity.Age;
            _context.SaveChanges();
        }
    }
}
