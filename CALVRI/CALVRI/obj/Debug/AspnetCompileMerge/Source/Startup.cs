using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CALVRI.Startup))]
namespace CALVRI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
