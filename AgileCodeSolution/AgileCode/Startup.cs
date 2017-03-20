using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgileCode.Startup))]
namespace AgileCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
