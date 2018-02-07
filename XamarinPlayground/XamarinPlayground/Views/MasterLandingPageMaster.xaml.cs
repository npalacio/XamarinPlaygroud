using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPlayground.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterLandingPageMaster : ContentPage
    {
        public ListView ListView;

        public MasterLandingPageMaster()
        {
            InitializeComponent();

            BindingContext = new MasterLandingPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterLandingPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterLandingPageMenuItem> MenuItems { get; set; }
            
            public MasterLandingPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterLandingPageMenuItem>(new[]
                {
                    new MasterLandingPageMenuItem { Id = 0, Title = "Page 1" },
                    new MasterLandingPageMenuItem { Id = 1, Title = "Page 2" },
                    new MasterLandingPageMenuItem { Id = 2, Title = "Page 3" },
                    new MasterLandingPageMenuItem { Id = 3, Title = "Page 4" },
                    new MasterLandingPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}