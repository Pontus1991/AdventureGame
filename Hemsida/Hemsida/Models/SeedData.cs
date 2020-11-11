using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Hemsida.Data;
using System;
using System.Linq;


namespace Hemsida.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HemsidaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<HemsidaContext>>()))
            {
                // Look for any movies.
                if (context.Login.Any())
                {
                    return;   // DB has been seeded
                }

                context.Login.AddRange(
                    new Login
                    {
                        UserName = "Pontus",
                        PassWord = "Frojd"  
                    } 
                );
                context.SaveChanges();
            }
        }
    }
}
