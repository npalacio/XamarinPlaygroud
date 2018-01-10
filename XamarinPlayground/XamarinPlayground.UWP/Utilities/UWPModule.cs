using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinPlayground.UWP.ServiceImplementations;

namespace XamarinPlayground.UWP.Utilities
{
    class UWPModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var employeeService = new EmployeeService();
            builder.RegisterInstance(employeeService).AsImplementedInterfaces();
        }
    }
}
