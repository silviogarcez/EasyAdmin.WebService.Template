using EasyAdmin.WebService.Template.Domain.Abstractions.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EasyAdmin.WebService.Template.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemplateController : ControllerBase
    {
        private readonly ILogger logger;

        public TemplateController(ILogger logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<ITemplateDomain> Get()
        {
            return Enumerable.Empty<ITemplateDomain>();
        }
    }
}
