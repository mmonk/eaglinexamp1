using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eaglinexamp1.Startup))]
namespace eaglinexamp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
