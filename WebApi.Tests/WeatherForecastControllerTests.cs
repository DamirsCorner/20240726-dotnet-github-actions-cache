using FluentAssertions;
using WebApi.Controllers;

namespace WebApi.Tests;

public class WeatherForecastControllerTests
{
    [Test]
    public void GetReturnsForecastForFiveDays()
    {
        var controller = new WeatherForecastController();

        var forecasts = controller.Get();

        forecasts.Should().HaveCount(5);
    }
}
