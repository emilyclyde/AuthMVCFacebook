using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthMVCFacebook.Startup))]
namespace AuthMVCFacebook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
