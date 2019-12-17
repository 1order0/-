using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Look.Startup))]
namespace Look
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
