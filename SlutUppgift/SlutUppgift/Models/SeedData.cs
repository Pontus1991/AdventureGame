using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SlutUppgift.Controllers;
using SlutUppgift.Data;
using SlutUppgift.Models;
using System;
using System.Linq;

namespace SlutUppgift.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SlutUppgiftContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SlutUppgiftContext>>()))
            {    
                if (context.Track.Any())
                {
                    return;   // DB has been seeded
                }

                context.Track.AddRange(
                    new Track
                    {
                        Price = 5,
                        Age = 25,
                        FirstName = "Pontus",
                        LastName = "Fröjd",
                        PhoneNumber = "0737058360"
                    },

                    new Track
                    {
                        Price = 5,
                        Age = 25,
                        FirstName = "Pontus",
                        LastName = "Fröjd",
                        PhoneNumber = "0737058360"
                    },

                    new Track
                    {
                        Price = 5,
                        Age = 25,
                        FirstName = "Pontus",
                        LastName = "Fröjd",
                        PhoneNumber = "0737058360"
                    },

                    new Track
                    {
                        Price = 5,
                        Age = 25,
                        FirstName = "Pontus",
                        LastName = "Fröjd",
                        PhoneNumber = "0737058360"
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}
