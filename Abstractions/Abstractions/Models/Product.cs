namespace Abstractions.Models
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public abstract string GetInfo();
    }
}
