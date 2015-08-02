using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMoveIdentity.Startup))]
namespace TestMoveIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
