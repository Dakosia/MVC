using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCExamShop.AdminEx.Startup))]
namespace MVCExamShop.AdminEx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
