
public class Program
{
    public static  async Task PerformLongOperationAsync()
    {

        try
        {
        Console.WriteLine("before start");
        await Task.Delay(3000);
        throw new InvalidOperationException("simulate exception");
        Console.WriteLine("operation complete");
            
        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"Exception: {ex.Message}");
        }

    }

    public static async Task Main(string[] args)
    {
        await PerformLongOperationAsync();
        Console.WriteLine("main task completed");
    }
}