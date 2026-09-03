using EmployeeManagement.Application.DTOs;
using EmployeeManagement.Application.Interfaces;

namespace EmployeeManagement.Application.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<EmployeeDto>> GetEmployeesAsync()
        {
            var employees = await _repository.GetEmployeesAsync();

            var employeeDtos = employees.Select(e => new EmployeeDto
            {
                Id = e.Id,
                Name = e.Name,
                Email = e.Email
            }).ToList();

            return employeeDtos;
        }
    }
}
