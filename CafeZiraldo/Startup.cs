using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CafeZiraldo.Startup))]
namespace CafeZiraldo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
