namespace WeatherMonitoringApp;
using WeatherMonitoringSystem;
using System;
class Program
{
   static void Main(string[] args)
        {
            ///<summary>
            /// Create a WeatherData instance
            /// </summary>
            WeatherData weatherData = WeatherData.GetInstance();
            WeatherStation weatherStation = new WeatherStation();
            IDisplay currentConditionsDisplay = weatherStation.CreateDisplay("CurrentConditions", "Additional Information Here");
            ///<summary>
            /// Create display objects
            /// </summary>
           
            IDisplay statisticsDisplay = new StatisticsDisplay();
            IDisplay forecastDisplay = new ForecastDisplay();

            /// Register display objects as observers
            weatherData.RegisterObserver(currentConditionsDisplay);
            weatherData.RegisterObserver(statisticsDisplay);
            weatherData.RegisterObserver(forecastDisplay);

            /// Simulate weather data changes
            weatherData.UpdateWeatherData();
        }
    }