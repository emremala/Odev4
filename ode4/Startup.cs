using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(odev4.Startup))]
namespace odev4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
