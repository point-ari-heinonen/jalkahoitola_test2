using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jalkahoitola_test2.Startup))]
namespace Jalkahoitola_test2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
