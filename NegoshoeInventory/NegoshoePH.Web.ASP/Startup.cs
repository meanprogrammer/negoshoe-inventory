using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NegoshoePH.Web.ASP.Startup))]
namespace NegoshoePH.Web.ASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
