using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPlayground.Services;
using XamarinPlayground.ViewModels;

namespace XamarinPlayground.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LandingPage : ContentPage
	{
		public LandingPage ()
		{
			InitializeComponent ();
            BindingContext = new LandingViewModel(ServiceLocator.Current.GetInstance<IEmployeeService>(), Navigation);
		}
	}
}