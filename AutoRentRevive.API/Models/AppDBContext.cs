using AutoRentRevive.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoRentRevive.API.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Basic Department Details
            modelBuilder.Entity<Department>().HasData
            (
                new Department
                {
                    DepartmentId = 1,
                    Department_Name = "Information Technology",
                    Department_Code = "IT",
                    IsActive = true
                }
            );
            modelBuilder.Entity<Department>().HasData
            (
                new Department
                {
                    DepartmentId = 2,
                    Department_Name = "Human Resource",
                    Department_Code = "HR",
                    IsActive = true
                }
            );
                modelBuilder.Entity<Department>().HasData
            (
                new Department
                {
                    DepartmentId = 3,
                    Department_Name = "Finance",
                    Department_Code = "FIN",
                    IsActive = true
                }
            );
            modelBuilder.Entity<Department>().HasData
            (
                new Department
                {
                    DepartmentId = 4,
                    Department_Name = "Marketing",
                    Department_Code = "MKT",
                    IsActive = true
                }
            );
            modelBuilder.Entity<Department>().HasData
            (
                new Department
                {
                    DepartmentId = 5,
                    Department_Name = "Admin",
                    Department_Code = "ADM",
                    IsActive = true
                }
            );
            modelBuilder.Entity<Department>().HasData
            (
                new Department
                {
                    DepartmentId = 6,
                    Department_Name = "Payroll",
                    Department_Code = "PRL",
                    IsActive = true
                }
            );

            //Seed Basic Department Details
            modelBuilder.Entity<AutoRentRevive.Models.Employee>().HasData
            (
                new AutoRentRevive.Models.Employee
                {
                    EmployeeId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Gender = Gender.Male,
                    Email = "johnDoe@gmail.com",
                    DateofBirth = new DateTime(1990, 5, 15),
                    DepartmentId = 1,
                    IsActive = true
                }
            );
            modelBuilder.Entity<AutoRentRevive.Models.Employee>().HasData
            (
                new AutoRentRevive.Models.Employee
                {
                    EmployeeId = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Gender = Gender.Female,
                    Email = "janeSmith@gmail.com",
                    DateofBirth = new DateTime(1985, 8, 20),
                    DepartmentId = 2,
                    IsActive = true
                }
            );
            modelBuilder.Entity<AutoRentRevive.Models.Employee>().HasData
            (
                new AutoRentRevive.Models.Employee
                {
                    EmployeeId = 3,
                    FirstName = "Michael",
                    LastName = "Brown",
                    Gender = Gender.Male,
                    Email = "michaelBrown@gmail.com",
                    DateofBirth = new DateTime(1992, 3, 10),
                    DepartmentId = 3,
                    IsActive = true
                }
            );
            modelBuilder.Entity<AutoRentRevive.Models.Employee>().HasData
            (
                new AutoRentRevive.Models.Employee
                {
                    EmployeeId = 4,
                    FirstName = "Emily",
                    LastName = "Davis",
                    Gender = Gender.Female,
                    Email = "emilyDavis@gmail.com",
                    DateofBirth = new DateTime(1995, 12, 25),
                    DepartmentId = 4,
                    IsActive = true
                }
            );
            modelBuilder.Entity<AutoRentRevive.Models.Employee>().HasData
            (
                new AutoRentRevive.Models.Employee
                {
                    EmployeeId = 6,
                    FirstName = "Sara",
                    LastName = "parker",
                    Gender = Gender.Female,
                    Email = "saraparker@gmail.com",
                    DateofBirth = new DateTime(1995, 12, 25),
                    DepartmentId = 2,
                    IsActive = true
                }
            );
        }
    }
}
