using AutoRentRevive.Models;
using AutoRentRevive.Web.BaseComponent.Actions;
using AutoRentRevive.Web.Services.DepartmentService;

namespace AutoRentRevive.Web.Services.DepartmentService
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient HttpClient;
        public List<Department> Employees { get; set; } = new List<Department>();

        public DepartmentService(HttpClient HttpClient)
        {
            this.HttpClient = HttpClient;
        }


        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await HttpClient.GetFromJsonAsync<Department[]>("Department/GetDepartments");
        }

        public async Task<Department> GetDepartment(int DepartmentId)
        {
            return await HttpClient.GetFromJsonAsync<Department>($"/Department/GetDepartment/{DepartmentId}");
        }

        public async Task<Department?> AddDepartment(Department Department)
        {
            var response = await HttpClient.PostAsJsonAsync("/Department/AddDepartment", Department);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Department>();
            }
            else
            {
                return null;
            }
        }

        public async Task<Department?> DeleteDepartment(Department Department)
        {
            return await HttpClient.DeleteFromJsonAsync<Department>($"Employee/DeleteEmployee/{Department.DepartmentId}/{Department.IsActive}");
        }

        public async Task<Department?> UpdateDepartment(Department Department)
        {
            var response = await HttpClient.PutAsJsonAsync($"Employee/UpdateEmployee/{Department.DepartmentId}?{Department.DepartmentId}", Department);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Department>();
            }
            else
            {
                return null;
            }
        }
    }

}
