using Microsoft.Owin;
using Owin;
using SignalRChat.Core;

[assembly: OwinStartup(typeof(Startup))]
namespace SignalRChat.Core
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}