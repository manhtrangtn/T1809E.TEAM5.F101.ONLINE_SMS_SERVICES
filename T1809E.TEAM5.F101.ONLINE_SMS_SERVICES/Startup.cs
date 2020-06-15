using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(T1809E.TEAM5.F101.ONLINE_SMS_SERVICES.Startup))]
namespace T1809E.TEAM5.F101.ONLINE_SMS_SERVICES
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
