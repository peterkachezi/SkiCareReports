using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkiCareHMSReport.Startup))]
namespace SkiCareHMSReport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
