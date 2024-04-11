namespace WeatherMonitoringSystem;
public class CurrentConditionsDisplay : IDisplay
    {
        /// <summary>
        /// Additional information to be displayed
        /// </summary>
        private readonly string additionalInformation;

        public CurrentConditionsDisplay(string additionalInformation)
        {
            this.additionalInformation = additionalInformation;
        }

        public void Display()
        {
            /// Display additional information along with weather conditions
            Console.WriteLine("Additional Information: " + additionalInformation);
            Console.WriteLine("Current conditions:");
            
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            
            Console.WriteLine($"Temperature: {temperature}°C, Humidity: {humidity}%, Pressure: {pressure}hPa");
        }
    } 