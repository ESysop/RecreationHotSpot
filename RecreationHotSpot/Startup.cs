using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecreationHotSpot.Startup))]
namespace RecreationHotSpot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
