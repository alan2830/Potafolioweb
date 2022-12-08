using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Potafolioweb.Startup))]
namespace Potafolioweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
