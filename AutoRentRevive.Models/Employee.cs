using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRentRevive.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [MinLength(2)]
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateofBirth { get; set; } = DateTime.Today;
        public Gender Gender { get; set; }
        public Department? Department { get; set; }
        public int DepartmentId { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedTime { get; set; } = DateTime.Today;
        public DateTime? UpdatedTime { get; set; } = null;
        public int CreatedById { get; set; }
        public int UpdatedById { get; set; }

    }
   
}
