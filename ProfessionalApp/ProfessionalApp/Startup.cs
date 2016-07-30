using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProfessionalApp.Startup))]
namespace ProfessionalApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
