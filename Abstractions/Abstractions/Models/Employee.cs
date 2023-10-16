namespace Abstractions.Models
{
    public class Employee : Person
    {
        private int _workingHour;
        public double SalaryOfHour { get; set; }
        public int WorkingHour
        {
            get => _workingHour;
            set
            {
                if (value / 30 < 8)
                    _workingHour = value;
                else
                    _workingHour = -1;
            }
        }
        public double CalculateSalary()
        {
            return SalaryOfHour * WorkingHour;
        }


    }
}
