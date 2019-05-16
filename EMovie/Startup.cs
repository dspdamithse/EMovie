using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EMovie.Startup))]
namespace EMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
