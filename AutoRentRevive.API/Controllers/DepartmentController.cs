using AutoRentRevive.API.Models.DepartmentModel;
using AutoRentRevive.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoRentRevive.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }
        [HttpGet("GetDepartments/")]
        public async Task<ActionResult> GetDepartments()
        {
            try
            {
                return Ok(await departmentRepository.GetDepartments());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data From Database");
            }
        }
        [HttpGet("GetDepartment/{departmentid:int}")]
        public async Task<ActionResult> GetDepartment(int departmentid)
        {
            try
            {
                var department = await departmentRepository.GetDepartment(departmentid);
                if (department == null)
                {
                    return NotFound();
                }
                return Ok(department);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data From Database"+ex);
            }
        }
        [HttpPost("AddDepartment/")]
        public async Task<ActionResult> AddDepartment([FromBody] Department department)
        {
            try
            {
                if (department == null)
                {
                    return BadRequest();
                }


                var createdDepartment = await departmentRepository.AddDepartment(department);
                return CreatedAtAction(nameof(GetDepartment), new { id = createdDepartment.DepartmentId }, createdDepartment);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data From Database");
            }
        }
        //[HttpPut("{id:int}")]
        //public async Task<IActionResult> UpdateEmployee(int employeeId, [FromBody] Employee employee)
        //{
        //    try
        //    {
        //        if (employee.EmployeeId == employeeId)
        //        {
        //            return BadRequest("Provided Employee ID Mismatch");
        //        }

        //        if (departmentRepository.GetEmployee(employee.EmployeeId) == null)
        //        {
        //            return NotFound($"Employee with Employee Id {employeeId} is not found.");
        //        }

        //        var updatedEmployee = await departmentRepository.UpdateEmployee(employee);
        //        if (updatedEmployee == null)
        //        {
        //            return NotFound();
        //        }
        //        return Ok(updatedEmployee);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data From Database");
        //    }
        //}
        //[HttpDelete("{employeeid:int}")]
        //public async Task<ActionResult<Employee>> DeleteEmployee(int employeeid)
        //{
        //    try
        //    {
        //        if (await departmentRepository.GetEmployee(employeeid) == null)
        //        {
        //            return NotFound($"Employee with Employee Id {employeeid} is not found.");
        //        }

        //        return await departmentRepository.DeleteEmployee(employeeid);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data From Database");
        //    }
        //}
    }
}
