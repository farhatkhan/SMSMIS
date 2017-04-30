using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAppghazi.Startup))]
namespace TestAppghazi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
