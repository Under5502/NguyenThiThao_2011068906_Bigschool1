using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bigschool1.Startup))]
namespace Bigschool1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
