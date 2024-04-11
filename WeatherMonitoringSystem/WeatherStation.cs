namespace WeatherMonitoringSystem;
public class WeatherStation
{
    // Factory method to create different types of displays.
    public IDisplay CreateDisplay(string displayType)
    {
        switch (displayType)
        {
            case "CurrentConditions":
                return new CurrentConditionsDisplay();
            case "Statistics":
                return new StatisticsDisplay();
            case "Forecast":
                return new ForecastDisplay();
            default:
                throw new ArgumentException("Invalid display type");
        }
    }
}