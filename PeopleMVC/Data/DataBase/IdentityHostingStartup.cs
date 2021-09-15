using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PeopleMVC.Data.Database;
using PeopleMVC.Data.DataManagement.User;

[assembly: HostingStartup(typeof(PeopleMVC.Data.Database.IdentityHostingStartup))]
namespace PeopleMVC.Data.Database
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<UserContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("UserDB")));

                services.AddIdentity<ApplicationUser, IdentityRole>(o =>
                {
                    o.SignIn.RequireConfirmedAccount = false;
                })
               .AddEntityFrameworkStores<UserContext>()
               .AddDefaultTokenProviders();

            });


        }
    }
}