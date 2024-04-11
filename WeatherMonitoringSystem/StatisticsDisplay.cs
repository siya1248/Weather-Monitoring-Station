namespace WeatherMonitoringSystem;
public class StatisticsDisplay : IDisplay
    {
        /// <summary>
        /// Implementing the IDisplay interface
        /// </summary>
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
            Console.WriteLine("Weather statistics:");
            
        }
    }