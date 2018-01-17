using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Models.ViewModelParameters;
using Xamarin.Forms;
using XamarinPlayground.Services;
using XamarinPlayground.Views;

namespace XamarinPlayground.ViewModels
{
    class LandingViewModel : ObservableObject
    {
//        public string TestVar { get; private set; }
//        public IEmployeeService EmployeeService { get; private set; }
//        public Employee Employee { get; private set; }
        public ICommand SearchCommand { get; private set; }
        public INavigation Navigation { get; private set; }
        public string SearchText { get; private set; }

        public LandingViewModel(IEmployeeService employeeService, INavigation navigation)
//        public LandingViewModel(INavigation navigation)
        {
//            this.TestVar = "test var working";
//            EmployeeService = employeeService;
//            Employee = EmployeeService.GetEmployees()[0];
            SearchCommand = new Command((searchText) => ChangeEmployee((string) searchText));
            Navigation = navigation;
        }

        void ChangeEmployee(string text)
        {
            var empListParams = new EmployeeListParams()
            {
                SearchText = text
            };
            Navigation.PushAsync(new EmployeeListPage(empListParams)).Wait();
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
