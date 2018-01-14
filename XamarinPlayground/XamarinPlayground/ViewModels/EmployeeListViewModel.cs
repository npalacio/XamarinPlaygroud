using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace XamarinPlayground.ViewModels
{
    class EmployeeListViewModel : ObservableObject
    {
        public string TestVar { get; private set; }

        public EmployeeListViewModel()
        {
            TestVar = "from employee list vm";
        }
    }
}
