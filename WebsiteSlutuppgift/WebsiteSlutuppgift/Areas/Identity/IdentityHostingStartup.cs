using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebsiteSlutuppgift.Areas.Identity.Data;
using WebsiteSlutuppgift.Data;

[assembly: HostingStartup(typeof(WebsiteSlutuppgift.Areas.Identity.IdentityHostingStartup))]
namespace WebsiteSlutuppgift.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebsiteSlutuppgiftContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebsiteSlutuppgiftContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireLowercase = false;                
                })
                   .AddEntityFrameworkStores<WebsiteSlutuppgiftContext>();

            });
        }
    }
}