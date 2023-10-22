using EmployeeDepEnumTask.Enums;
using EmployeeDepEnumTask.Models;

namespace EmployeeDepEnumTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            Department department1 = new Department();

            Employee employee = new Employee
            {
                Name = "Elsever",
                Surname = "Asadov",
                Age = 30,
                DepartmentNo = 1,
                Position = Position.Developer,
                Salary = 1200
            };
            Employee employee1 = new Employee
            {
                Name = "Remzi",
                Surname = "Hasanov",
                Age = 15,
                DepartmentNo = 1,
                Position = Position.HR,
                Salary = 2000
            };
            Employee employee2 = new Employee
            {
                Name = "Shahin",
                Surname = "Ismayilov",
                Age = 45,
                DepartmentNo = 2,
                Position = Position.Developer,
                Salary = 500
            }; ;
            Employee employee3 = new Employee
            {
                Name = "Elmar",
                Surname = "ByK",
                Age = 36,
                DepartmentNo = 2,
                Position = Position.HR,
                Salary = 600
            }; ;

            department.EmployeeLimit = 10;
            department.No = 1;
            department1.EmployeeLimit = 10;
            department.No = 2;

            department.AddEmployee(employee1);
            department.AddEmployee(employee);

            department1.AddEmployee(employee2);
            department1.AddEmployee(employee3);

            foreach (var item in department1.GetAllEmployeesBySalary(100, 3000))
            {
                Console.WriteLine(item);
            };

            //foreach (var item in department.GetAllEmployees())
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}