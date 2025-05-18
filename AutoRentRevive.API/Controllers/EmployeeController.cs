using AutoRentRevive.API.Models.EmployeeModel;
using AutoRentRevive.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoRentRevive.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee employeeRepository;
        public EmployeeController(IEmployee employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [HttpGet("GetEmployees/")]
        public async Task<ActionResult> GetEmployees()
        {
            try
            {
                return Ok(await employeeRepository.GetEmployees());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data From Database\n"+ ex);
            }
        }
        [HttpGet("GetEmployee/{employeeid:int}")]
        public async Task<ActionResult> GetEmployee(int employeeid)
        {
            try
            {
                var employee = await employeeRepository.GetEmployee(employeeid);
                if (employee == null)
                {
                    return NotFound();
                }
                return Ok(employee);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data From Database");
            }
        }
        [HttpPost("AddEmployee/")]
        public async Task<ActionResult> AddEmployee([FromBody] Employee employee)
        {
            try
            {
                if (employee == null)
                {
                    return BadRequest();
                }

                //if (employeeRepository.GetEmployeeByEmail(employee.Email) != null)
                //{
                //    ModelState.AddModelError("Email", "Email already exists");
                //    return BadRequest(ModelState);
                //}

                var createdEmployee = await employeeRepository.AddEmployee(employee);
                return CreatedAtAction(nameof(GetEmployee), new { id = createdEmployee.EmployeeId }, createdEmployee);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data From Database");
            }
        }
        [HttpPut("UpdateEmployee/{id:int}")]
        public async Task<IActionResult> UpdateEmployee(int employeeId,[FromBody] Employee employee)
        {
            try
            {
                if (employee.EmployeeId == employeeId)
                {
                    return BadRequest("Provided Employee ID Mismatch");
                }

                if (await employeeRepository.GetEmployee(employee.EmployeeId) == null)
                {
                    return NotFound($"Employee with Employee Id {employeeId} is not found.");
                }

                var updatedEmployee = await employeeRepository.UpdateEmployee(employee);
                if (updatedEmployee == null)
                {
                    return NotFound();
                }
                return Ok(updatedEmployee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data From Database");
            }
        }
        [HttpDelete("DeleteEmployee/{employeeid:int}/{IsActive:bool}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int employeeid, bool IsActive)
        {
            try
            {
                //if (await employeeRepository.GetEmployee(employeeid) == null)
                //{
                //    return NotFound($"Employee with Employee Id {employeeid} is not found.");
                //}

                return await employeeRepository.DeleteEmployee(employeeid, IsActive);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Retrieving Data From Database");
            }
        }
    }
}
