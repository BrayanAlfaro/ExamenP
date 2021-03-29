using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Problema7.Startup))]
namespace Problema7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
