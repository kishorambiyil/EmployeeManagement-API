using EmployeeManagement.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _employeeService.GetEmployeesAsync();

            return Ok(employees);
        }
        //private static readonly List<Employee> Employees = new()
        //{
        //    new Employee
        //    {
        //        Id = 1,
        //        Name = "John Gosalvas",
        //        Email = "john@example.com",
        //        Department = "IT"
        //    },
        //    new Employee
        //    {
        //        Id = 2,
        //        Name = "David",
        //        Email = "david@example.com",
        //        Department = "HR"
        //    }
        //};

        //[HttpGet]
        //public IActionResult GetEmployees()
        //{
        //    return Ok(Employees);
        //}

        //[HttpGet("{id}")]
        //public IActionResult GetEmployee(int id)
        //{
        //    var employee = Employees.FirstOrDefault(x => x.Id == id);

        //    if (employee == null)
        //        return NotFound();

        //    return Ok(employee);
        //}

        
    }
}
