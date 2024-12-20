using Microsoft.AspNetCore.Mvc;
using WebApi3.Data;

namespace WebApi3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
 private readonly AppDbContext _context;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(AppDbContext context, ILogger<WeatherForecastController> logger)
        {
            _context = context;
            _logger = logger;
        }

       [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            // Fetch data from the database instead of generating it
            return _context.WeatherData.ToList();
        }
    }
}
