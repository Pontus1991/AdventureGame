using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SlutUppgift.Areas.Identity.Data;
using SlutUppgift.Data;

[assembly: HostingStartup(typeof(SlutUppgift.Areas.Identity.IdentityHostingStartup))]
namespace SlutUppgift.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SlutUppgiftContext2>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SlutUppgiftContext2Connection")));

                services.AddDefaultIdentity<SlutUppgiftUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SlutUppgiftContext2>();
            });
        }
    }
}