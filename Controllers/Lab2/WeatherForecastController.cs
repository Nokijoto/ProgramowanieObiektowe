
using Laboratorium_2_20_10_2022.Services.Lab2;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_2_20_10_2022.Controllers.Lab2
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public int Get()
        {
            var calculateInstance = new Calculate(1);
            calculateInstance.Increase(100);
            calculateInstance.Decrease(14);
            return calculateInstance.GetValue();
        }
    }
}