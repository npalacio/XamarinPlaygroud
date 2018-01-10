using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinPlayground.Services;

namespace XamarinPlayground.UWP.ServiceImplementations
{
    class EmployeeService : IEmployeeService
    {
        public List<Employee> GetEmployees() {
            return new List<Employee>() {
                new Employee(){ Name = "Nick" }
            };
        }
    }
}
