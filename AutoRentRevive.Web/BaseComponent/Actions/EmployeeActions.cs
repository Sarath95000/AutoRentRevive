using AutoRentRevive.Models;
using AutoRentRevive.Web.Services.EmployeeService;
using Microsoft.AspNetCore.Components;
using System.Linq;

namespace AutoRentRevive.Web.BaseComponent.Actions
{
    public class EmployeeActions : ComponentBase
    {
        public void AddEmployee(Employee employee)
        {
            if (employee == null || string.IsNullOrWhiteSpace(employee.Email))
                return;
            /*-------------------------------------------------------------- Need A Rewrite -------------------------------------------------------------- */

            //if (!EmployeeService.Employees.Any(e => e.Email == employee.Email))
            //{
            //    EmployeeService.Employees.Add(new Employee
            //    {
            //        EmployeeId = EmployeeService.Employees.Count + 1,
            //        FirstName = employee.FirstName,
            //        LastName = employee.LastName,
            //        Email = employee.Email,
            //        DateofBirth = employee.DateofBirth,
            //        Department = employee.Department,
            //        Gender = employee.Gender,
            //        IsActive = true
            //    });

            //    employee.Email = string.Empty;
            //    employee.FirstName = string.Empty;
            //    employee.LastName = string.Empty;
            //    employee.DateofBirth = DateTime.MinValue;
            //    employee.Department = null;
            //    employee.Gender = Gender.Other;
            //}
        }

        public void EditEmployee(Employee employee)
        {            /*-------------------------------------------------------------- Need A Rewrite -------------------------------------------------------------- */

            //var employeeToUpdate = EmployeeService.Employees.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId && x.Email == employee.Email);

            //if (employeeToUpdate != default)
            //{
            //    employeeToUpdate.FirstName = employee.FirstName;
            //    employeeToUpdate.LastName = employee.LastName;
            //    employeeToUpdate.Email = employee.Email;
            //    employeeToUpdate.DateofBirth = employee.DateofBirth;
            //    employeeToUpdate.Department = employee.Department;
            //    employeeToUpdate.Gender = employee.Gender;
            //    employeeToUpdate.IsActive = employee.IsActive;
            //}
        }

        public void DeleteEmployee(Employee employee)
        {            /*-------------------------------------------------------------- Need A Rewrite -------------------------------------------------------------- */

            //var emp = EmployeeService.Employees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);
            //if (emp != null)
            //{
            //    emp.IsActive = false;
            //}
        }
    }
}
