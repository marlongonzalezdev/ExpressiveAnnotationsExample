using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingExpressiveAnnotations.Startup))]
namespace TestingExpressiveAnnotations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
