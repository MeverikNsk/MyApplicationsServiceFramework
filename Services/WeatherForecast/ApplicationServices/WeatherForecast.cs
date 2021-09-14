using System.Collections.Generic;
using System.Linq;
using API;
using API.Models;
using Domain;

namespace ApplicationServices
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastDomainService _weatherForecastDomainService;

        public WeatherForecastService(
            IWeatherForecastDomainService weatherForecastDomainService)
        {
            _weatherForecastDomainService = weatherForecastDomainService;
        }        
        
        public IEnumerable<WeatherForecast> GetWeather()
        {
            return _weatherForecastDomainService.GetWeather().Select(index => new WeatherForecast {
                Date = index.Date,
                TemperatureC = index.TemperatureC,
                TemperatureF = index.TemperatureF,
                Summary = index.Summary
            })
            .ToArray();        
        }
    }
}
