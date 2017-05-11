using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TPCSample.Startup))]
namespace TPCSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
