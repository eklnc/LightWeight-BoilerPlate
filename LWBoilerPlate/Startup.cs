using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(LWBoilerPlate.Startup))]

namespace LWBoilerPlate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
