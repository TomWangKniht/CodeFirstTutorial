using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TPTSample.Startup))]
namespace TPTSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
