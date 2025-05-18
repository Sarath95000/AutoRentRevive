using AutoRentRevive.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoRentRevive.API.Models.EmployeeModel
{
    public class EmployeeRepository : IEmployee
    {
        private readonly AppDBContext Repository;

        public EmployeeRepository(AppDBContext appDBContext)
        {
            Repository = appDBContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            employee.IsActive = true; 
            employee.CreatedTime = DateTime.Now;
            var result = Repository.Employees.AddAsync(employee);
            await Repository.SaveChangesAsync();
            return result.Result.Entity;
        }

        public async Task<Employee> DeleteEmployee(int employeeId, bool IsActive)
        {
            var result = await Repository.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
            if (result != null)
            {
                //Repository.Employees.Remove(result); it will Do Soft Delete
                result.IsActive= false;
                await Repository.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            var result = await Repository.Employees.Include(x => x.Department).FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
            if (result != null)
            {
                return result;
            }
            return result;
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            var result = await Repository.Employees
                                .Include(x => x.Department)
                                    .FirstOrDefaultAsync(e => e.Email == email);
            if (result != null)
            {
                return result;
            }
            return result;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await Repository.Employees
                            .Include(x => x.Department)
                            .ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var employeesToUpdate = await Repository.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);
            if (employeesToUpdate != null)
            {
                employeesToUpdate.FirstName = employee.FirstName;
                employeesToUpdate.LastName = employee.LastName;
                employeesToUpdate.Email = employee.Email;
                employeesToUpdate.DateofBirth = employee.DateofBirth;
                employeesToUpdate.Gender = employee.Gender;
                employeesToUpdate.IsActive = employee.IsActive;
                employeesToUpdate.DepartmentId = employee.DepartmentId;
                employeesToUpdate.UpdatedTime = DateTime.Now;

                await Repository.SaveChangesAsync();

                return employeesToUpdate;
            }
            return employeesToUpdate;
        }
    }
}
