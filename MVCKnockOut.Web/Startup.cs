using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCKnockOut.Web.Startup))]
namespace MVCKnockOut.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
