using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MolvenoLakeResort.Startup))]
namespace MolvenoLakeResort
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
