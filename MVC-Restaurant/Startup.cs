using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Restaurant.Startup))]
namespace MVC_Restaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
