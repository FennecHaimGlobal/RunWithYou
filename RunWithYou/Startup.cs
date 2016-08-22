using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RunWithYou.Startup))]
namespace RunWithYou
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
