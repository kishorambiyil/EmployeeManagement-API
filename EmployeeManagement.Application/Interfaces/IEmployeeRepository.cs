using EmployeeManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployeesAsync();
    }
}
