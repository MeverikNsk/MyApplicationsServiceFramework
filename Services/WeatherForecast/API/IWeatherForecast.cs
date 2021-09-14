using System.Collections.Generic;
using API.Models;
using Framework.Attributes;

namespace API
{
    [ApplicationService]
    public interface IWeatherForecastService
    {
         IEnumerable<WeatherForecast> GetWeather();
    }
}