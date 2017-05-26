using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReferenceMVC523.Startup))]
namespace ReferenceMVC523
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
