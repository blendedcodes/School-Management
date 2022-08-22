using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(School_Management.Startup))]
namespace School_Management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
