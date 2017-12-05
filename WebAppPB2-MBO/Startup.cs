using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppPB2_MBO.Startup))]
namespace WebAppPB2_MBO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
