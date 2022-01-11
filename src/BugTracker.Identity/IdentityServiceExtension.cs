using BugTracker.Application.Contracts.Identity;
using BugTracker.Application.Model.Identity;
using BugTracker.Identity.Data;
using BugTracker.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BugTracker.Identity
{
    public static class IdentityServiceExtension
    {
        public static void AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<IdentityDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("IdentityDb"),
               b => b.MigrationsAssembly(typeof(IdentityDbContext).Assembly.FullName)));


            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<IdentityDbContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(opt =>
            {
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
                opt.Lockout.MaxFailedAccessAttempts = 5;
                opt.Password.RequiredLength = 9;
                opt.Password.RequireDigit = true;
                opt.Password.RequireLowercase = true;
                opt.Password.RequireUppercase = true;
                opt.Password.RequireNonAlphanumeric = false;
                opt.SignIn.RequireConfirmedEmail = true;

            });
            services.AddScoped<IIdentityService, IdentityService>();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/Login";
            });

        }

    }
}
