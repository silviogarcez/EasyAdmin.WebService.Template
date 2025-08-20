using EasyAdmin.Caching.Abstractions.Interfaces;
using EasyAdmin.WebService.Template.Repository.Abstractions.Interfaces;
using EasyAdmin.WebService.Template.Services.Abstractions.Interfaces;

namespace EasyAdmin.WebService.Template.Services
{
    public class TemplateService : ITemplateService
    {
        private readonly ITemplateRepository templateRepository;
        private readonly ICache cache;

        public TemplateService(ITemplateRepository templateRepository, ICache cache)
        {
            this.templateRepository = templateRepository;
            this.cache = cache;
        }
    }
}
