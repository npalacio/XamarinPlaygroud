using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinPlayground.Services;

namespace XamarinPlayground.UWP.ServiceImplementations
{
    class EmployeeService : IEmployeeService
    {
        public IEnumerable<Employee> GetEmployees() {
            return new ObservableCollection<Employee>() {
                new Employee(){ Name = "Nick" },
                new Employee(){ Name = "Dory" },
                new Employee(){ Name = "Mark" },
                new Employee(){ Name = "Chris" },
                new Employee(){ Name = "Shannon" },
                new Employee(){ Name = "George" },
                new Employee(){ Name = "Brenda" }
            };
        }
    }
}
