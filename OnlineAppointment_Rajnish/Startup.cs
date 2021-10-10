using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineAppointment_Rajnish.Startup))]
namespace OnlineAppointment_Rajnish
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
