using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(conroy_mis4200_sd2.Startup))]
namespace conroy_mis4200_sd2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
