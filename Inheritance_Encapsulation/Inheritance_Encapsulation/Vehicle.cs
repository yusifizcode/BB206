namespace Inheritance_Encapsulation
{
    public class Vehicle
    {
        public Vehicle(string brand, string model)
        {
            this.Model = model;
            this.Brand = brand;
        }

        private string _model;
        private string _brand;
        private double _mile;

        public string Model
        {
            get => _model;
            set
            {
                if (value.Length > 3 && value.Length < 30)
                {
                    _model = value;
                }
            }
        }
        public string Brand
        {
            get => _brand;
            set
            {
                if (value.Length > 3 && value.Length < 30)
                {
                    _brand = value;
                }
            }
        }

        public double Mile
        {
            get => _mile;
            set
            {
                if (value > 0) _mile = value;
            }
        }
    }
}
