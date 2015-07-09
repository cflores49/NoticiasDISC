using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NoticiasDISC.Startup))]
namespace NoticiasDISC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
