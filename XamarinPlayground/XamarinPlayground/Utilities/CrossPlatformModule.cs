using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPlayground.Utilities
{
    class CrossPlatformModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // This is where you would register services that can be used cross-platform
        }
    }
}
