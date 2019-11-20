using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proyecto_20266787.Startup))]
namespace Proyecto_20266787
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
