using Microsoft.AspNetCore.Components;
using AutoRentRevive.Models;

namespace AutoRentRevive.Web.BaseComponent
{
    /*
    public class EmployeeListBase : ComponentBase
    {
        public Employee Employee { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees()
        {
            Employee employee1 = new Employee
            {
                FirstName = "John",
                LastName = "Doe",
                Gender = Gender.Male,
                Email = "johnDoe@gmail.com",
                DateofBirth = new DateTime(1990, 5, 15),
                Department = new Department
                {
                    DepartmentId = 1,
                    DepartmentName = "IT"
                }
            };

            Employee employee2 = new Employee
            {
                FirstName = "Jane",
                LastName = "Smith",
                Gender = Gender.Female,
                Email = "janeSmith@gmail.com",
                DateofBirth = new DateTime(1985, 8, 20),
                Department = new Department
                {
                    DepartmentId = 2,
                    DepartmentName = "HR"
                }
            };

            Employee employee3 = new Employee
            {
                FirstName = "Michael",
                LastName = "Brown",
                Gender = Gender.Male,
                Email = "michaelBrown@gmail.com",
                DateofBirth = new DateTime(1992, 3, 10),
                Department = new Department
                {
                    DepartmentId = 3,
                    DepartmentName = "Finance"
                }
            };

            Employee employee4 = new Employee
            {
                FirstName = "Emily",
                LastName = "Davis",
                Gender = Gender.Female,
                Email = "emilyDavis@gmail.com",
                DateofBirth = new DateTime(1995, 12, 25),
                Department = new Department
                {
                    DepartmentId = 4,
                    DepartmentName = "Marketing"
                }
            };

            Employees = new List<Employee> { employee1, employee2, employee3, employee4 };
        }

        public void DeleteEmployee(Employee employee)
        {
            var emp = Employees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);
            if (emp != null)
            {
                emp.IsDeleted = true; 
                StateHasChanged(); 
            }
        }

        public void AddEmployee(Employee employee)
        {
            if (!Employees.Any(employees => employees.Email == employee.Email))
            {
                Employees.Add(
                                new Employee
                                {
                                    EmployeeId = Employees.Count + 1,
                                    FirstName = employee.FirstName,
                                    LastName = employee.LastName,
                                    Email = employee.Email,
                                    DateofBirth = employee.DateofBirth,
                                    Department = employee.Department,
                                    Gender = employee.Gender,
                                    IsDeleted = false
                                });
                employee.Email = string.Empty;
            }


            StateHasChanged();

            // Reset the Employee object to clear the form fields
        }
    }
    */
}
