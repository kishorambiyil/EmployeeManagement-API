using EmployeeManagement.Application.Interfaces;
using EmployeeManagement.Domain;
using EmployeeManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace EmployeeManagement.Infrastructure
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            var employees = await _context.Employees.ToListAsync();

            return employees;
        }
    }
}
