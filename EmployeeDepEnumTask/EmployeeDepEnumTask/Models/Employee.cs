using EmployeeDepEnumTask.Enums;

namespace EmployeeDepEnumTask.Models
{
    public class Employee
    {
        private static int _id;
        private double _salary;
        private string _name;
        public int Id { get; }
        public string Name
        {
            get => _name;
            set
            {
                if (Helper.CheckNameOrSurname(value))
                {
                    _name = value;
                }
            }
        }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public int DepartmentNo { get; set; }
        public Position Position { get; set; }
        public double Salary
        {
            get => _salary;
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
            }
        }

        static Employee()
        {
            _id = 0;
        }

        public Employee()
        {
            _id++;
            Id = _id;
        }
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Surname: {Surname} Position: {Position}";
        }
    }
}
