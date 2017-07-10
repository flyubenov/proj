using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DynamicMenu461.Startup))]
namespace DynamicMenu461
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
