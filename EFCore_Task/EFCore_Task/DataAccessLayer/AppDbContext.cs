using EFCore_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Task.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-L6JGBQE\\SQLEXPRESS;Database=BB206Movies;Trusted_Connection=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
