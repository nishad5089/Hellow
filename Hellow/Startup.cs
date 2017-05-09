using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hellow.Startup))]
namespace Hellow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
