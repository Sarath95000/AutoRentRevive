using AutoRentRevive.Models;

namespace AutoRentRevive.API.Models.DepartmentModel
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int DepartmentId);
        Task<Department> AddDepartment(Department Department);
        Task<Department> UpdateDepartment(Department Department);
        Task<Department> DeleteDepartment(int DepartmentId);
    }
}
