class Program
{
    static void Main()
    {
        NotificationFactory factory = new NotificationFactory();// this could be static!!!

        INotification emailNotifier = factory.CreateNotification("Email");
        emailNotifier.Send("Hello via Email!");

        INotification smsNotifier = factory.CreateNotification("SMS");
        smsNotifier.Send("Hello via SMS!");

        // INotification invalidNotifier = factory.CreateNotification("Unknown"); // This will throw an exception
    }
}