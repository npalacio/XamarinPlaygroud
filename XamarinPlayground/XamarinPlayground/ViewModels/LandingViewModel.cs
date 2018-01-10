using FirstXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPlayground.ViewModels
{
    class LandingViewModel : ObservableObject
    {
        public string TestVar { get; private set; }

        public LandingViewModel() {
            this.TestVar = "test var working";
        }

    }
}
