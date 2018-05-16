using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cartas.Startup))]
namespace Cartas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
