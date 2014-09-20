using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerServicesDemo
{
    public class AppHost : AppHostBase
    {
        //Tell ServiceStack the name of your application and where to find your services
        public AppHost() : base("Customer Services", typeof(CustomerServices).Assembly) { }

        public override void Configure(Funq.Container container)
        {
            //register any dependencies your services use, e.g:
            //container.Register<ICacheClient>(new MemoryCacheClient());
        }
    }
}