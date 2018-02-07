using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Models.ViewModelParameters;
using Xamarin.Forms;
using XamarinPlayground.Services;
using XamarinPlayground.Views;

namespace XamarinPlayground.ViewModels
{
    public class EmployeeSearchViewModel
    {
        public string Title { get; private set; }
        public ICommand SearchCommand { get; private set; }
//        public IEmployeeService EmployeeService { get; private set; }
        public INavigation Navigation { get; private set; }

//        public EmployeeSearchViewModel(IEmployeeService empService, INavigation nav)
        public EmployeeSearchViewModel(INavigation nav)
        {
            Title = "Employee Search Page";
//            EmployeeService = empService;
            Navigation = nav;
            SearchCommand = new Command(searchText => ChangeEmployee((string) searchText));
        }
        void ChangeEmployee(string text)
        {
            var empListParams = new EmployeeListParams()
            {
                SearchText = text
            };
            Navigation.PushAsync(new EmployeeListPage(empListParams)).Wait();
        }
    }
}
