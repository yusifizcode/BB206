using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employees = GetEmployees();
            List<Department> departments = GetDepartments();

            HomeViewModel homeView = new HomeViewModel();
            homeView.Employees = employees;
            homeView.Departments = departments;

            return View(homeView);
        }

        public IActionResult Detail(int id)
        {
            List<Employee> employees = GetEmployees();

            Employee existEmployee = employees.FirstOrDefault(x => x.Id == id);

            if (existEmployee == null) return NotFound();

            return View(existEmployee);
        }

        private List<Employee> GetEmployees()
        {
            return new List<Employee> {
                new Employee{Id=1,FullName = "Filankes1 Filankesov",Age=31,Salary=2100,DepartmentId=1},
                new Employee{Id=2,FullName = "Filankes2 Filankesov",Age=32,Salary=2200,DepartmentId=2},
                new Employee{Id=3,FullName = "Filankes3 Filankesov",Age=33,Salary=2300,DepartmentId=2},
                new Employee{Id=4,FullName = "Filankes4 Filankesov",Age=34,Salary=2400,DepartmentId=3},
                new Employee{Id=5,FullName = "Filankes5 Filankesov",Age=35,Salary=2500,DepartmentId=4},
                new Employee{Id=6,FullName = "Filankes6 Filankesov",Age=36,Salary=2600,DepartmentId=5},
            };
        }

        private List<Department> GetDepartments()
        {
            return new List<Department> {
                new Department{Id=1,Name="IT"},
                new Department{Id=2,Name="Marketing"},
                new Department{Id=3,Name="Sales"},
                new Department{Id=4,Name="SMM"},
                new Department{Id=5,Name="Accounting"},
                new Department{Id=6,Name="Moyka"},
            };
        }
    }
}
