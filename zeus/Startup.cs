using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zeus.Startup))]
namespace zeus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
