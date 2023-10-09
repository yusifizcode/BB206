namespace Inheritance_Encapsulation
{
    public class Notebook : Product
    {
        private byte _ram;
        public byte RAM
        {
            get => _ram;
            set
            {
                if (value > 0)
                {
                    _ram = value;
                }
            }
        }
        public int Storage { get; set; }

        public string GetFullInfo()
        {
            return $"Name: {Name} Count: {Count} IsStock: {IsStock}";
        }

        public void ShowFullData()
        {
            Console.WriteLine(GetFullInfo());
        }
    }
}
