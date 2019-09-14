using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCExamShop.Startup))]
namespace MVCExamShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
