namespace WeatherMonitoringSystem;
public class WeatherData
    {
        private static WeatherData instance;
        private Random random = new Random();
        private List<IDisplay> observers = new List<IDisplay>();

        private WeatherData() { }

        public static WeatherData GetInstance()
        {
            if (instance == null)
            {
                instance = new WeatherData();
            }
            return instance;
        }

        public void UpdateWeatherData()
        {
            double temperature = random.Next(-20, 40);
            double humidity = random.Next(0, 100);
            double pressure = random.Next(980, 1050);

            NotifyObservers(temperature, humidity, pressure);
        }

        public void Attach(IDisplay observer)
        {
            observers.Add(observer);
        }

        public void Detach(IDisplay observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers(double temperature, double humidity, double pressure)
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }
    }