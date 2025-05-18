using AutoRentRevive.Models;
using AutoRentRevive.Web.Services.DepartmentService;
using Microsoft.AspNetCore.Components;

namespace AutoRentRevive.Web.Services.EmployeeService
{
    public class EmployeeListBase : ComponentBase
    {
        

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }


        public Employee Employee { get; set; } = new Employee();
        public IEnumerable<Employee> Employees { get; set; } = new List<Employee>();
        public IEnumerable<Department> Departments { get; set; } = new List<Department>();
        public List<Employee> FilteredEmployees { get; set; } = new List<Employee>();

        public string searchText { get; set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
            Departments = (await DepartmentService.GetDepartments()).ToList();
            FilteredEmployees = Employees.ToList(); // Initialize with all employees
        }

        public void SearchEmployees()
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                FilteredEmployees = Employees.ToList();
            }
            else
            {
                FilteredEmployees = Employees
                    .Where(e =>
                        (e.FirstName + " " + e.LastName).Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                        e.Email.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                        (int.TryParse(searchText, out var id) && e.EmployeeId == id)
                    ).ToList();
            }
        }

        public void EditEmployee(Employee Editemployee)
        {
            var employee = Employees.First(e => e.EmployeeId == Editemployee.EmployeeId);

            if (employee != null)
            {
                Navigation.NavigateTo($"/editemployee/{employee.EmployeeId}");
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            if (employee != null)
            {
                Navigation.NavigateTo($"/deleteemployee/{employee.EmployeeId}");
            }
        }
    }
}
