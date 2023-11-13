namespace EFCore_Task.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int DirectorId { get; set; }
    }
}
