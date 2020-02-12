using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ident.Startup))]
namespace Ident
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
