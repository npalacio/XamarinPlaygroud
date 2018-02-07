using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using Models.ViewModelParameters;
using XamarinPlayground.Services;

namespace XamarinPlayground.ViewModels
{
    class EmployeeListViewModel : ObservableObject
    {
        public string TestVar { get; private set; }
        public string SearchText { get; private set; }
        public IEmployeeService EmployeeService { get; private set; }
        public IEnumerable<Employee> Employees { get; private set; }
        public IEnumerable<Employee> FilteredEmployees { get; private set; }

        private Employee _selectedEmployee;
        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                if (!value.Equals(_selectedEmployee))
                {
                    _selectedEmployee = value;
                }
            }
        }

        public EmployeeListViewModel(EmployeeListParams parameters, IEmployeeService empService)
        {
            TestVar = "from employee list vm";
            SearchText = parameters.SearchText;
            EmployeeService = empService;
            Employees = EmployeeService.GetEmployees();
            FilterEmployees();
        }

        private void FilterEmployees()
        {
            FilteredEmployees = SearchText != null ? 
                Employees.Where(emp => emp.Name.IndexOf(SearchText, 0, StringComparison.CurrentCultureIgnoreCase) > -1) 
                : Employees;
        }
    }
}
