using ClassTask.Exceptions;

namespace ClassTask.Models
{
    public class Product
    {
        private static int _no;
        private static double _price;
        public int No { get; set; }
        public string Name { get; set; }
        public double Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new PriceMustBeGratherThanZeroException("Price menfi ola bilmez!!");
                }
            }
        }
        public Enums.Type Type { get; set; }

        static Product()
        {
            _no = 0;
        }

        public Product(int no, string name, double price, Enums.Type type)
        {
            _no++;
            No = _no;
            Name = name;
            Price = price;
            Type = type;
        }
    }
}
