using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.DataProtection;

[assembly: OwinStartup(typeof(RecordData.Startup))]

namespace RecordData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = UnityConfig.RegisterComponents(app.GetDataProtectionProvider());
            ConfigureAuth(app);
        }
    }
}
