using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheMysterySchool.Startup))]
namespace TheMysterySchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
