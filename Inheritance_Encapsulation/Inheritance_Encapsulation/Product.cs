namespace Inheritance_Encapsulation
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public bool IsStock { get; set; } = true;
        private double _price;
        public double Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }

        public void Sale()
        {
            if (Count > 0)
            {
                Count--;
            }
            else
            {
                IsStock = false;
            }
        }
    }
}
