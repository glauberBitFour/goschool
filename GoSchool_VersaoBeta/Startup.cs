using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoSchool_VersaoBeta.Startup))]
namespace GoSchool_VersaoBeta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
