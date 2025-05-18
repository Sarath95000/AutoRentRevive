using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRentRevive.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Department_Code { get; set; }
        public string Department_Name { get; set; }
        public bool IsActive { get; set; } = true;
        public string GroupName { get; set; } = String.Empty;
        public DateTime CreatedTime { get; set; } = DateTime.Today;
        public DateTime? UpdatedTime { get; set; } = null;
        public int CreatedById { get; set; }
        public int UpdatedById { get; set; }
    }
}
