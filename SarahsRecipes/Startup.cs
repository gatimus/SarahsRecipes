using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SarahsRecipes.Startup))]
namespace SarahsRecipes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
