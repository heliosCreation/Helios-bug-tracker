using BugTracker.Application.Contracts.Identity;
using BugTracker.Domain.Identity;
using BugTracker.Persistence.Services.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace BugTracker.Persistence
{
    public static class IdentityServiceExtension
    {
        public static void AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("BugTrackerDb"),
               b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));


            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

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
                opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+/ ";
            });
            services.AddScoped<IIdentityService, IdentityService>();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/Login";
            });

            services.AddAuthorization(options =>
            {

                options.AddPolicy("NoDemo", policy =>
                {
                    policy.RequireAuthenticatedUser();

                    policy.RequireAssertion(ctx =>
                    {
                        return ctx.User.Claims
                           .Where(c => c.Type == ClaimTypes.Role)
                           .Where(c => c.Value.Contains("Demo")).Select(c => c.Value)
                           .ToList().Count == 0;
                    });
                });

                options.AddPolicy("PriviledgedUser", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireAssertion(ctx =>
                    {
                        return ctx.User.Claims
                           .Where(c => c.Type == ClaimTypes.Role)
                           .Where(c => c.Value ==("Admin") || c.Value == ("Project Manager"))
                           .ToList().Count > 0;
                    });
                });

                options.AddPolicy("PriviledgedUserAndDemoPriviledged", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireAssertion(ctx =>
                    {
                        return ctx.User.Claims
                           .Where(c => c.Type == ClaimTypes.Role)
                           .Where(c => c.Value.Contains("Admin") || c.Value.Contains("Project Manager") || c.Value.Contains("Demo Admin") || c.Value.Contains("Demo Project Manager"))
                           .ToList().Count > 0;
                    });
                });

                options.AddPolicy("NotDev", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireAssertion(ctx =>
                    {
                        return ctx.User.Claims
                           .Where(c => c.Type == ClaimTypes.Role)
                           .Where(c => c.Value.ToLower().Contains("dev"))
                           .ToList().Count == 0;
                    });
                });
            });


        }

    }
}
