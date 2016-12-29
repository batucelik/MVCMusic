using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMusic.Startup))]
namespace MVCMusic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
