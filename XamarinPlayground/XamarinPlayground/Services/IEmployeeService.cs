using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPlayground.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
    }
}
