using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalculatorIO.Startup))]
namespace CalculatorIO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
