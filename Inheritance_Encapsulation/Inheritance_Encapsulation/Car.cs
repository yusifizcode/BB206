namespace Inheritance_Encapsulation
{
    internal class Car : Vehicle
    {
        public Car(string brand, string model) : base(brand, model) { }

        private int _doorsNum;
        public int DoorsNum
        {
            get => _doorsNum;
            set
            {
                if (value > 0 && value < 5) _doorsNum = value;
            }
        }

        public void ShowFullInfo()
        {
            Console.WriteLine($"{Brand} {Model} {DoorsNum}");
        }
    }
}
