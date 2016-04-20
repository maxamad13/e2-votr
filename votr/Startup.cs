using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(votr.Startup))]
namespace votr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
