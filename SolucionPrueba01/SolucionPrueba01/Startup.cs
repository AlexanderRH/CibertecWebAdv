using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SolucionPrueba01.Startup))]
namespace SolucionPrueba01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
