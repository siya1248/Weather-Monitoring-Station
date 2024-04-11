namespace WeatherMonitoringSystem;

public class WeatherData
    {
        // Step 1: Add a list to store observers
        private List<IDisplay> observers = new List<IDisplay>();
        private Random random = new Random();
        private WeatherData() { }

        // Step 2: Implement the Singleton pattern
        private static WeatherData instance; 

        public static WeatherData GetInstance()
        {
            if (instance == null)
            {
                instance = new WeatherData();
            }
            return instance;
        }

        // Step 3: Register observers
        public void RegisterObserver(IDisplay observer)
        {
            observers.Add(observer);
        }

        // Step 4: Remove observers
        public void RemoveObserver(IDisplay observer)
        {
            observers.Remove(observer);
        }

        // Step 5: Notify observers when weather data changes
        private void NotifyObservers(double temperature, double humidity, double pressure)
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        // Step 6: Update weather data and notify observers
        public void UpdateWeatherData()
        {
            double temperature = random.Next(-20, 40);
            double humidity = random.Next(0, 100);
            double pressure = random.Next(980, 1050);

            Console.WriteLine($"Weather updated: Temperature: {temperature}°C, Humidity: {humidity}%, Pressure: {pressure}hPa");
            
            // Notify observers when weather data changes
            NotifyObservers(temperature, humidity, pressure);
        }
    }