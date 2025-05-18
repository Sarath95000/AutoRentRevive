using AutoRentRevive.Models;

namespace AutoRentRevive.API.Models.EmployeeModel
{
    public interface IEmployee
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int employeeId);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int employeeId, bool IsActive);

    }
}
