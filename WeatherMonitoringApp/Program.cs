namespace WeatherMonitoringApp;
using WeatherMonitoringSystem;
using System;
class Program
{
   static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            WeatherStation weatherStation = new WeatherStation();

            IDisplay currentConditionsDisplay = weatherStation.CreateDisplay("CurrentConditions", weatherData);
            // Create other display objects as needed

            weatherData.SetData(80, 65, 30.4f);
            weatherData.SetData(82, 70, 29.2f);
            weatherData.SetData(78, 90, 29.2f);

            currentConditionsDisplay.Show();
            // Show other displays as needed
        }}