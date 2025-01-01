using LibraryManagementSystemBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystemBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("success/response")]
        public IActionResult CreateSuccessResponse()
        {
            var response = ApiResponse<string>.SuccessResponse("hello world");
            return Ok(response);
        }

        [HttpGet("failure/response")]
        public IActionResult CreateFailureResponse()
        {
            List<string> details = new List<string>()
            {
                "Name must be filled!",
                "Address must be filled!"
            };

            var response = ApiResponse<string>.FailureResponse(StatusCodes.Status400BadRequest, "Bad Request", null, details);
            return Ok(response);
        }
    }
}
