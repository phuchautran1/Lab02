using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2_TranPhucHau.Startup))]
namespace Lab2_TranPhucHau
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
