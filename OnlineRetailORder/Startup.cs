using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineRetailORder.Startup))]
namespace OnlineRetailORder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
