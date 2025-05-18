using AutoRentRevive.Models;
using AutoRentRevive.Web.BaseComponent.Actions;
using AutoRentRevive.Web.Services.DepartmentService;

namespace AutoRentRevive.Web.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient HttpClient;
        public List<Employee> Employees { get; set; } = new List<Employee>();
        //public List<Department> Departments { get; set; } = DepartmentService.Departments;
        
        public EmployeeService(HttpClient HttpClient)
        {
            this.HttpClient = HttpClient;
        }

        //public static void ExecuteEmployeeAction(EmployeeAction action, Employee employee)
        //{
        //    EmployeeActions employeeActions = new EmployeeActions();

        //    switch (action.ToString())
        //    {
        //        case "DeleteEmployee":
        //            employeeActions.DeleteEmployee(employee);
        //            break;
        //        case "AddEmployee":
        //            employeeActions.AddEmployee(employee);
        //            break;
        //        case "EditEmployee":
        //            employeeActions.EditEmployee(employee);
        //            break;
        //        default:
        //            throw new ArgumentException("Invalid action");
        //    }
        //}

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await HttpClient.GetFromJsonAsync<Employee[]>("Employee/GetEmployees");
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await HttpClient.GetFromJsonAsync<Employee>($"/Employee/GetEmployee/{employeeId}");
        }

        public async Task<Employee?> AddEmployee(Employee employee)
        {
            var response = await HttpClient.PostAsJsonAsync("/Employee/AddEmployee", employee);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Employee>();
            }
            else
            {
                return null;
            }
        }

        public async Task<Employee?> DeleteEmployee(Employee employee)
        {
            return await HttpClient.DeleteFromJsonAsync<Employee>($"Employee/DeleteEmployee/{employee.EmployeeId}/{employee.IsActive}");
        }

        public async Task<Employee?> UpdateEmployee(Employee employee)
        {
            var response = await HttpClient.PutAsJsonAsync($"Employee/UpdateEmployee/{employee.EmployeeId}?{employee.EmployeeId}", employee);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Employee>();
            }
            else
            {
                return null;
            }
        }
    }

}
