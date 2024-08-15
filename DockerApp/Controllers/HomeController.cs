using Microsoft.AspNetCore.Mvc;

namespace DockerApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet("config")]
        public string Config([FromQuery] string key)
        {
            return _configuration[key];
        }
    }
}
