using System.Collections.Generic;
using Domain.BusinessModels;

namespace Domain
{
    public interface IWeatherForecastDomainService
    {
        IEnumerable<WeatherForecastBO> GetWeather();
    }
}
