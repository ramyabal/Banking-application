using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BankingApplication.Startup))]
namespace BankingApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
