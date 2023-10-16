namespace Abstractions.Models
{
    public class Book : Product
    {
        public string Author { get; set; }
        public string Genre { get; set; }
        public override string GetInfo()
        {
            return $"{Name} {Price} - Author: {Author} Genre: {Genre}";
        }
    }
}
