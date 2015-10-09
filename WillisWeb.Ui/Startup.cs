using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WillisWeb.Ui.Startup))]
namespace WillisWeb.Ui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
