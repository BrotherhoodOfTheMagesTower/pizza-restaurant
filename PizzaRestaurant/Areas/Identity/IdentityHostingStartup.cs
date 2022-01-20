using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(PizzaRestaurant.Areas.Identity.IdentityHostingStartup))]
namespace PizzaRestaurant.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}