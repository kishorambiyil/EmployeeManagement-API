using EmployeeManagement.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDto>> GetEmployeesAsync();
    }
}
