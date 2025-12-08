using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Reflection;

namespace ASPZIZ_PK_New.Features;


public static class DependencyInjection
{
    extension (IServiceCollection source)
    {
        public IServiceCollection AddFeatures()
        {
            source.AddCQRS(Assembly.GetAssembly(typeof(DependencyInjection)));


            return source;
        }
    }
}
