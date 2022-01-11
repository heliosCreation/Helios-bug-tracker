using BugTracker.Application.Contracts.Infrastructure.Mail;
using BugTracker.Application.Model.Mail;
using BugTracker.Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddScoped<IEmailService, EmailService>();

            //services.AddSingleton(x => new BlobServiceClient(configuration.GetSection("BlobStorageSettings:ConnectionString").Value));
            //services.AddScoped<IFileStorageService, BlobStorageService>();


            //services.AddScoped<IImageHandlerService, ImageHandlerService>();

            return services;
        }
    }
}
