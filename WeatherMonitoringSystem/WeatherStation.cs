namespace WeatherMonitoringSystem;
public class WeatherStation
    {
        // Step 1: Implement the Factory pattern
        public IDisplay CreateDisplay(string displayType, string additionalInformation)
        {
            switch (displayType)
            {
                case "CurrentConditions":
                    // Provide additional information when creating CurrentConditionsDisplay
                    return new CurrentConditionsDisplay(additionalInformation);
                case "Statistics":
                    return new StatisticsDisplay();
                case "Forecast":
                    return new ForecastDisplay();
                default:
                    throw new ArgumentException("Invalid display type");
            }
        }
    }