namespace WeatherMonitoringSystem;
public class ForecastDisplay : IDisplay
    {
        ///  Implementing the IDisplay interface
        public void Display()
        {
            
        }

        /// <summary>
        /// Implementing the Update method to receive weather data updates
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        public void Update(double temperature, double humidity, double pressure)
        {
            Console.WriteLine("Weather forecast:");
            /// Update forecast with new weather data
        }
    }