using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mynewgitproject.Startup))]
namespace mynewgitproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
