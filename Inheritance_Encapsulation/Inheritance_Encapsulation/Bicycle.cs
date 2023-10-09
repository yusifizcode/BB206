namespace Inheritance_Encapsulation
{
    public class Bicycle : Vehicle
    {
        public Bicycle(string brand, string model) : base(brand, model) { }

        private int _wheelNum;
        public int WheelNum
        {
            get => _wheelNum;
            set
            {
                if (value > 0 && value < 5)
                {
                    _wheelNum = value;
                }
            }
        }

        public void ShowFullInfo()
        {
            Console.WriteLine($"{Brand} {Model} {WheelNum}");
        }
    }
}
