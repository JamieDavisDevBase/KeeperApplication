using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KeeperApplication.Startup))]
namespace KeeperApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
