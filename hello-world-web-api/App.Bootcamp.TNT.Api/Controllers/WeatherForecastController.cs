using Microsoft.AspNetCore.Mvc;

namespace App.Bootcamp.TNT.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    [HttpGet(Name = "GetWeatherForecast")]
    public WeatherForecast Get()
    {
         var resultado = new WeatherForecast
            {
                mensagem = "Hello World Staters!",
                url = "https://github.com/DavidTavares27"
            };
            return resultado;        
    
    }
}
