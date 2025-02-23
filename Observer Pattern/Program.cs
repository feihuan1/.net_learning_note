// one object notifies other objects when state changes
// use for event notification
// exp: user interface changes when data change
public class Program
{

    public static void Main(string[] args)
    {
        WeatherStation weatherStation = new WeatherStation();

        PhoneDisplay phoneDisplay = new PhoneDisplay();

        DesktopDisplay desktopDisplay = new DesktopDisplay();

        weatherStation.RegisterObserver(phoneDisplay);
        weatherStation.RegisterObserver(desktopDisplay);

        weatherStation.SetTemperature(25.0f); // set new data and notify

    }
}