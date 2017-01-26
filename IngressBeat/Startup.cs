using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IngressBeat.Startup))]
namespace IngressBeat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
