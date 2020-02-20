using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_NEW.Startup))]
namespace MVC_NEW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
