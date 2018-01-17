using CommonServiceLocator;
using Models.ViewModelParameters;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPlayground.Services;
using XamarinPlayground.ViewModels;

namespace XamarinPlayground.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmployeeListPage : ContentPage
	{
		public EmployeeListPage (EmployeeListParams parameters)
		{
			InitializeComponent ();
		    BindingContext = new EmployeeListViewModel(parameters, ServiceLocator.Current.GetInstance<IEmployeeService>());
		}
	}
}