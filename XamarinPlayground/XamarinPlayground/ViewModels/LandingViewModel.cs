using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinPlayground.Services;

namespace XamarinPlayground.ViewModels
{
    class LandingViewModel : ObservableObject
    {
        public string TestVar { get; private set; }
        public IEmployeeService EmployeeService { get; private set; }
        public Employee Employee { get; private set; }
        public ICommand TestCommand { get; private set; }

        public LandingViewModel(IEmployeeService employeeService)
        {
            this.TestVar = "test var working";
            this.EmployeeService = employeeService;
            this.Employee = EmployeeService.GetEmployees()[0];
            TestCommand = new Command(ChangeEmployee);
        }

        void ChangeEmployee()
        {
            Employee = new Employee()
            {
                Name = "Employee from command"
            };
            OnPropertyChanged("Employee");
        }
        //public LandingViewModel() {
        //    this.TestVar = "test var working";
        //}

    }
}
