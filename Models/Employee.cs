using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Employee : ObservableObject
    {
        private string name;
        public string Name {
            get => name;
            set {
                if (value != null) {
                    name = value;
                    OnPropertyChanged("Name");
                }
            } }

        public override bool Equals(object obj)
        {
            return obj != null && ((Employee)obj).Name == Name;
        }
    }
}
