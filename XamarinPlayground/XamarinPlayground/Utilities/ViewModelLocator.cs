using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPlayground.Utilities
{
    public class ViewModelLocator
    {
        public static void RegisterServices(ContainerBuilder platformSpecificRegistrations) {
            platformSpecificRegistrations.RegisterModule<CrossPlatformModule>();
            var container = platformSpecificRegistrations.Build();
            ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(container));
        }
    }
}
