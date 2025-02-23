public interface IObserver
{
    void Update(float temperature);
}

public class WeatherStation
{
    private List<IObserver> observers = new List<IObserver>();
    private float temperature;

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach(var observer in observers)
        {
            observer.Update(temperature);
        }
    }

    public void SetTemperature(float newTemperature)
    {
        temperature = newTemperature;
        NotifyObservers();
    }
}

public class PhoneDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("Phone display: Temperature updated to " + temperature + " degrees.");
    }
}
public class DesktopDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("DesktopDisplay display: Temperature updated to " + temperature + " degrees.");
    }
}