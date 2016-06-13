using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NFC.Web.Startup))]
namespace NFC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
