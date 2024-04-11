namespace WeatherMonitoringSystem;
public interface IDisplay
{
    void Display();
    void Update(double temperature, double humidity, double pressure);
}