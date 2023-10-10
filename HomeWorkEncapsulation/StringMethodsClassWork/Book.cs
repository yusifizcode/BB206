namespace StringMethodsClassWork
{
    public class Book
    {
        private double _price;
        public string Name { get; set; }
        public double Price
        {
            get => _price;
            set
            {
                if (value > 0) _price = value;
            }
        }
    }
}
