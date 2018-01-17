using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonServiceLocator;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPlayground.Services;
using XamarinPlayground.ViewModels;

namespace XamarinPlayground.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmployeeSearchPage : ContentPage
	{
		public EmployeeSearchPage ()
		{
			InitializeComponent ();
//            BindingContext = new EmployeeSearchViewModel(ServiceLocator.Current.GetInstance<IEmployeeService>(), Navigation);
            BindingContext = new EmployeeSearchViewModel(Navigation);
		}
	}
}