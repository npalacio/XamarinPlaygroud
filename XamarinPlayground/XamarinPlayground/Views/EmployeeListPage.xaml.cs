using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPlayground.ViewModels;

namespace XamarinPlayground.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmployeeListPage : ContentPage
	{
		public EmployeeListPage ()
		{
			InitializeComponent ();
		    BindingContext = new EmployeeListViewModel();
		}
	}
}