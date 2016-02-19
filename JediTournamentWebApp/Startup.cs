using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JediTournamentWebApp.Startup))]
namespace JediTournamentWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
