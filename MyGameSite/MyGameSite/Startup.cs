using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGameSite.Startup))]
namespace MyGameSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
