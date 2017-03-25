using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(seuranta.Startup))]
namespace seuranta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
