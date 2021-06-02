using System;
using BankingAPI.Areas.Identity.Data;
using BankingAPI.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BankingAPI.Areas.Identity.IdentityHostingStartup))]
namespace BankingAPI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<BankingAPIDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("BankingAPIDBContextConnection")));
                services.AddDefaultIdentity<BankingAPIUser>(options =>
                {
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.SignIn.RequireConfirmedAccount = false;
                });
                services.AddDefaultIdentity<BankingAPIUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<BankingAPIDBContext>();
            });
        }
    }
}