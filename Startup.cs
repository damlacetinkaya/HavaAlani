using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Havaalani.Startup))]
namespace Havaalani
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
