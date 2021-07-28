using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityFramwork_Athentication_MVC.Startup))]
namespace IdentityFramwork_Athentication_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
