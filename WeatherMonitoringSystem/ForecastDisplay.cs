namespace WeatherMonitoringSystem;
public class ForecastDisplay : IDisplay
{
    public void Display()
    {
        
    }
    public void Update(double temperature, double humidity, double pressure)
    {
        Console.WriteLine("Weather forecast:");
    }
}