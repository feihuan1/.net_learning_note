// a class can have only one instance
// pride a point of access from anywhere

public class Database
{
    private static Database? _instance;

    private Database()
    {
        Console.WriteLine("Database Connected");
    }

    public static Database GetInstance()
    {
        if(_instance == null)
        {
            _instance = new Database();
        }

        return _instance;
    }
}