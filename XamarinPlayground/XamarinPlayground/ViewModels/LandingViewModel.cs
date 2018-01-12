using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinPlayground.Services;
using XamarinPlayground.Views;

namespace XamarinPlayground.ViewModels
{
    class LandingViewModel : ObservableObject
    {
        public string TestVar { get; private set; }
        public IEmployeeService EmployeeService { get; private set; }
        public Employee Employee { get; private set; }
        public ICommand TestCommand { get; private set; }
        public INavigation Navigation { get; private set; }

        public LandingViewModel(IEmployeeService employeeService, INavigation navigation)
        {
//            this.TestVar = "test var working";
            EmployeeService = employeeService;
            Employee = EmployeeService.GetEmployees()[0];
            TestCommand = new Command(async () => await ChangeEmployee());
            Navigation = navigation;
        }

        async Task ChangeEmployee()
        {
            await Navigation.PushAsync(new EmployeeListPage());
//            Employee = new Employee()
//            {
//                Name = "Employee from command"
//            };
//            OnPropertyChanged("Employee");
        }
        //public LandingViewModel() {
        //    this.TestVar = "test var working";
        //}

    }
}
