using BugTracker.Application;
using BugTracker.Application.Contracts.Identity;
using BugTracker.Infrastructure;
using BugTracker.Persistence;
using BugTracker.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BugTracker
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews()
                    .AddRazorRuntimeCompilation();

            services.AddHttpContextAccessor();
            services.AddScoped<ILoggedInUserService, LoggedInUserService>();

            services.AddApplicationService();
            services.AddInfrastructureServices(Configuration);
            services.AddIdentityServices(Configuration);
            services.AddPersistenceService();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.Use(async (ctx, next) =>
            {
                var ep = ctx.Features.Get<IEndpointFeature>()?.Endpoint;
                var authAttr = ep?.Metadata?.GetMetadata<AuthorizeAttribute>();

                if (authAttr != null && authAttr.Policy == "HasRole")
                {
                    var authService = ctx.RequestServices.GetRequiredService<IAuthorizationService>();
                    var result = await authService.AuthorizeAsync(ctx.User, ctx.GetRouteData(), authAttr.Policy);
                    if (!result.Succeeded)
                    {
                        var path = $"/Identity/Account/Pending?ReturnUrl={ctx.Request.Path}";
                        ctx.Response.Redirect(path);
                        return;
                    }
                }
                await next();
            });
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=DashBoard}");

                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Account}/{action=Login}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


        }
    }
}
