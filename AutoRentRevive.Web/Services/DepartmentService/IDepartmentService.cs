using AutoRentRevive.Models;

namespace AutoRentRevive.Web.Services.DepartmentService
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int DepartmentId);
        Task<Department?> AddDepartment(Department Department);
        Task<Department?> DeleteDepartment(Department Department);
        Task<Department?> UpdateDepartment(Department Department);

    }
}



