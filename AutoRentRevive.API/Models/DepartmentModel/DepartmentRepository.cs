using AutoRentRevive.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoRentRevive.API.Models.DepartmentModel
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDBContext Repository;

        public DepartmentRepository(AppDBContext appDBContext)
        {
            Repository = appDBContext;
        }

        public async Task<Department> AddDepartment(Department Department)
        {
            Department.IsActive = true;
            Department.CreatedTime = DateTime.Now;
            Department.CreatedById = 1;
            var result = Repository.Departments.AddAsync(Department);
            await Repository.SaveChangesAsync();
            return result.Result.Entity;
        }

        public async Task<Department> DeleteDepartment(int DepartmentId)
        {
            var result = await Repository.Departments.FirstOrDefaultAsync(e => e.DepartmentId == DepartmentId);
            if (result != null)
            {
                Repository.Departments.Remove(result);
                await Repository.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Department> GetDepartment(int DepartmentId)
        {
            var result = await Repository.Departments.FirstOrDefaultAsync(e => e.DepartmentId == DepartmentId);
            if (result != null)
            {
                return result;
            }
            return result;
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await Repository.Departments.ToListAsync();
        }

        public async Task<Department> UpdateDepartment(Department Department)
        {
            var DepartmentsToUpdate = await Repository.Departments.FirstOrDefaultAsync(e => e.DepartmentId == Department.DepartmentId);
            if (DepartmentsToUpdate != null)
            {
                DepartmentsToUpdate.Department_Name = Department.Department_Name;
                DepartmentsToUpdate.Department_Code = Department.Department_Code;
                DepartmentsToUpdate.IsActive = Department.IsActive;

                await Repository.SaveChangesAsync();

                return DepartmentsToUpdate;
            }
            return DepartmentsToUpdate;
        }
    }
}
