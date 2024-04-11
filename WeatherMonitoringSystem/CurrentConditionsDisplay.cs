namespace WeatherMonitoringSystem;
public class CurrentConditionsDisplay : IDisplay
{
     private double temperature;
        private double humidity;
        private double pressure;
    private readonly string additionalInformation;

        public CurrentConditionsDisplay(string additionalInformation)
        {
            this.additionalInformation = additionalInformation;
        }

        public void Display()
        {
            
            Console.WriteLine("Additional Information: " + additionalInformation);
            Console.WriteLine("Current conditions:");
            
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }
}