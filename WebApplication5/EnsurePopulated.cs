using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication5
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AirportContext context = app.ApplicationServices
                .GetRequiredService<AirportContext>();
           // context.Database.Migrate();
            if (!context.Tickets.Any())
            {
                context.Tickets.AddRange(
                    new Ticket()
                    {
                        Id = 1,
                        Price = 1M,
                        FlightNumber = "",
                    },
                    new Ticket()
                    {
                        Id = 2,
                        Price = 1M,
                        FlightNumber = "",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
