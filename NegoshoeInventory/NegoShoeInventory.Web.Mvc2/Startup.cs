using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NegoShoeInventory.Web.Mvc2.Startup))]
namespace NegoShoeInventory.Web.Mvc2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
