using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(phand1k.Startup))]
namespace phand1k
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
