using EasyAdmin.Repository.Context;
using EasyAdmin.WebService.Template.Repository.Abstractions.Interfaces;
using EasyAdmin.WebService.Template.Services;
using EasyAdmin.WebService.Template.Services.Abstractions.Interfaces;

namespace EasyAdmin.WebService.Template.Extensions
{
    public static class TemplateExtensions
    {
        public static IServiceCollection AddTemplateExtensions(this IServiceCollection services)
        {            
            services.AddScoped<ITemplateService, TemplateService>();
            services.AddScoped<IEasyAdminContext, EasyAdminContext>();
            return services;
        }
    }
}
