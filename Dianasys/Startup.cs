using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dianasys.Startup))]
namespace Dianasys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
