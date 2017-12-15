using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PublicLooks.Startup))]
namespace PublicLooks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
