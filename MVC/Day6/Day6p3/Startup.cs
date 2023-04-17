using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day6p3.Startup))]
namespace Day6p3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
