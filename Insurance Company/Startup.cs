using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Insurance_Company.Startup))]
namespace Insurance_Company
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
