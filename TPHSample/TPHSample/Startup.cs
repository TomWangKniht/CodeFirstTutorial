using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TPHSample.Startup))]
namespace TPHSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
