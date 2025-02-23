public interface INotification
{
    void Send(string message);
}

public class EmailNotification: INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }
}

public class SMSNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}

public class NotificationFactory
{
    public INotification CreateNotification(string channle)
    {
        if(channle == "Email")
        {
            return new EmailNotification();
        }
        else if(channle == "SMS")
        {
            return new SMSNotification();
        }
        else
        {
            throw new ArgumentException("ARE u kidding me!!!");
        }
    }
}