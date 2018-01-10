using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPlayground.ViewModels
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LandingViewModel : ContentPage
	{
		public LandingViewModel ()
		{
			InitializeComponent ();
		}
	}
}