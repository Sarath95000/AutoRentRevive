using AutoRentRevive.Web.Services.DepartmentService;
using AutoRentRevive.Models;
using Microsoft.AspNetCore.Components;

namespace AutoRentRevive.Web.Services.DepartmentService
{
    public class DepartmentListBase : ComponentBase
    {

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }


        public IEnumerable<Department> Department { get; set; } = new List<Department>();
        public IEnumerable<Department> Departments { get; set; } = new List<Department>();
        public List<Department> FilteredDepartments { get; set; } = new List<Department>();

        public string searchText { get; set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            Departments = (await DepartmentService.GetDepartments()).ToList();
            FilteredDepartments = Departments.ToList(); 
        }

        public void SearchDepartment()
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                FilteredDepartments = Departments.ToList();
            }
            else
            {
                FilteredDepartments = Departments
                    .Where(e =>
                        (e.Department_Name).Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                        e.Department_Code.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                        (int.TryParse(searchText, out var id) && e.DepartmentId == id)
                    ).ToList();
            }
        }

        public void EditDepartment(Department EditDepartment)
        {
            var employee = Departments.First(e => e.DepartmentId == EditDepartment.DepartmentId);

            //if (employee != null)
            //{
            //    Navigation.NavigateTo($"/editemployee/{employee.EmployeeId}");
            //}
        }

        public void DeleteDepartment(Department Department)
        {
            //if (Department != null)
            //{
            //    Navigation.NavigateTo($"/deleteemployee/{employee.EmployeeId}");
            //}
        }
    }
}
