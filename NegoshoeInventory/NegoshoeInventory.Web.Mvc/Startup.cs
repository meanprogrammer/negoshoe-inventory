using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NegoshoeInventory.Web.Mvc.Startup))]
namespace NegoshoeInventory.Web.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
