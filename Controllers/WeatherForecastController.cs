using Microsoft.AspNetCore.Mvc;
using API1.Class; 
namespace API1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        MathService clsMathService = new MathService();

        [HttpGet("Add")]
        public double GetAdd(double num1, double num2)
        {
            return clsMathService.Add(new double[] { num1, num2 });
        }

        [HttpGet("Sum")]
        public double GetSum([FromQuery] double[] nums)
        {
            return clsMathService.Sum(nums);
        }

        [HttpGet("Sub")]
        public double GetSub([FromQuery] double[] nums)
        {
            return clsMathService.Sub(nums);
        }

        [HttpGet("Mult")]
        public double GetMult([FromQuery] double[] nums)
        {
            return clsMathService.Mult(nums);
        }

        [HttpGet("Div")]
        public double GetDiv([FromQuery] double[] nums)
        {
            return clsMathService.Div(nums);
        }

        [HttpGet("Max")]
        public double GetMax([FromQuery] double[] nums)
        {
            return clsMathService.Max(nums);
        }

        [HttpGet("Min")]
        public double GetMin([FromQuery] double[] nums)
        {
            return clsMathService.Min(nums);
        }

        [HttpGet("Factorial")]
        public double GetFact(int num)
        {
            return clsMathService.Factorial(new double[] { num });
        }

        [HttpGet("Percent")]
        public double GetPer(double num1, double num2)
        {
            return clsMathService.Precent(new double[] { num1, num2 });
        }

        [HttpGet("Depercent")]
        public double GetDePer(double num1, double num2)
        {
            return clsMathService.Depercent(new double[] { num1, num2 });
        }

        [HttpGet("Count")]
        public double GetCount([FromQuery] List<double> nums)
        {
            return clsMathService.Count(nums.ToArray());
        }


        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
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
    } 
} 