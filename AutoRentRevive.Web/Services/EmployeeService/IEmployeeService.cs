using AutoRentRevive.Models;

namespace AutoRentRevive.Web.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee?> AddEmployee(Employee employee);
        Task<Employee?> DeleteEmployee(Employee employee);
        Task<Employee?> UpdateEmployee(Employee employee);

    }
}
