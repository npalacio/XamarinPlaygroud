using Models;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinPlayground.Views;

namespace XamarinPlayground.ViewModels
{
    public class LandingViewModel : ObservableObject
    {
        public string Title { get; private set; }
        public ICommand GoToSearch { get; private set; }
        public INavigation Navigation { get; private set; }
        public string SearchBtnText { get; private set; }

        public LandingViewModel(INavigation navigation)
        {
            Title = "Welcome to EmergencyResponse";
            GoToSearch = new Command(GoToEmployeeSearch);
            Navigation = navigation;
            SearchBtnText = "Go to Employee Search";
        }

        void GoToEmployeeSearch()
        {
            Navigation.PushAsync(new EmployeeSearchPage()).Wait();
        }
    }
}
