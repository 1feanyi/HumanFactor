using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HumanFactor.Startup))]
namespace HumanFactor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
