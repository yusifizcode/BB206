using EmployeeDepEnumTask.Enums;

namespace EmployeeDepEnumTask.Models
{
    public class Department
    {
        public int No { get; set; }
        private Employee[] _employees = new Employee[0];


        public int EmployeeLimit { get; set; }
        public void AddEmployee(Employee employee)
        {
            if (EmployeeLimit >= _employees.Length)
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[^1] = employee;
            }
            else
            {
                Console.WriteLine("Limit ashilib!!");
            }
        }

        public void AddEmployee(ref Employee[] employees, Employee employee)
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[^1] = employee;
        }

        public Employee GetEmployee(int id)
        {
            foreach (var emp in _employees)
            {
                if (emp.Id == id)
                {
                    return emp;
                }
            }
            return null;
        }

        public Employee[] GetAllEmployees() => _employees;

        public Employee[] GetAllEmployeesBySalary(double minSalary, double maxSalary)
        {
            Employee[] filteredEmployees = new Employee[0];

            foreach (var emp in _employees)
            {
                if (emp.Salary >= minSalary && emp.Salary <= maxSalary)
                {
                    AddEmployee(ref filteredEmployees, emp);
                }
            }

            return filteredEmployees;
        }

        public Employee[] GetAllEmployeesByPosition(Position position)
        {
            Employee[] filteredEmployees = new Employee[0];

            foreach (var emp in _employees)
            {
                if (emp.Position == position)
                {
                    AddEmployee(ref filteredEmployees, emp);
                }
            }

            return filteredEmployees;
        }

        public Employee[] GetAllEmployeesByDepartmentNo(int depNo)
        {
            Employee[] filteredEmployees = new Employee[0];

            foreach (var emp in _employees)
            {
                if (emp.DepartmentNo == depNo)
                {
                    AddEmployee(ref filteredEmployees, emp);
                }
            }

            return filteredEmployees;
        }
    }
}
