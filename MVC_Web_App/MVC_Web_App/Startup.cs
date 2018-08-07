using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Web_App.Startup))]
namespace MVC_Web_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
