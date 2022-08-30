using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.WeatherForecasts.Queries.GetWeatherForecasts;

namespace Portfolio.WebUI.Controllers;
public class WeatherForecastController : ApiControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await Mediator.Send(new GetWeatherForecastsQuery());
    }
}
