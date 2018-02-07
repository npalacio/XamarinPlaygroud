using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPlayground.Views.MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterLandingPage : MasterDetailPage
    {
        public MasterLandingPage()
        {
            InitializeComponent();
//            Title = "Nick master page";
//            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

//        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
//        {
//            var item = e.SelectedItem as MasterLandingPageMenuItem;
//            if (item == null)
//                return;
//
//            var page = (Page)Activator.CreateInstance(item.TargetType);
//            page.Title = item.Title;
//
//            Detail = new NavigationPage(page);
//            IsPresented = false;
//
//            MasterPage.ListView.SelectedItem = null;
//        }
    }
}