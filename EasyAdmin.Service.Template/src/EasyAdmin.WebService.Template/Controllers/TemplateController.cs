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

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<ITemplate> Get()
        //{

        //}
    }
}
