using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NathanLeigh.Startup))]
namespace NathanLeigh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
