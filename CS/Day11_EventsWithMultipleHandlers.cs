class WeatherMonitor
{
    public delegate void TemparatureHandler(string message);
    public event TemparatureHandler? OnTemperatureAlert;

    public void CheckTemperature(double temp)
    {
        Console.WriteLine("Current temperature is: "+temp);
        if(temp > 40.0)
        {
            OnTemperatureAlert("Temperature Too High");
        }
    }
}

public class UseEvents
{
    static void DisplayDevice(string msg) => Console.WriteLine("Display Device Alert message: "+msg);
    static void CoolingSystem(string msg) => Console.WriteLine("Cooling System is Activated: "+msg);
    static void Main(String[] args)
    {
        WeatherMonitor weatherMonitor = new WeatherMonitor();
        weatherMonitor.OnTemperatureAlert += DisplayDevice;
        weatherMonitor.OnTemperatureAlert += CoolingSystem;

        weatherMonitor.CheckTemperature(45.5);
    }
}