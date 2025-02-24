

public class Program
{

    public async Task DownloadDataAsync()
    {
        Console.WriteLine("Download Start");
        await Task.Delay(3000);
        Console.WriteLine("Download Done");
    }
    public async Task DownloadDataAsync2()
    {
        Console.WriteLine("Download2 Start");
        try
        {
            throw new Exception("simulate exception");
            await Task.Delay(2000);
        }
        catch (Exception ex)
        {
            Console.WriteLine("error: " + ex.Message);
        }
        Console.WriteLine("Download2 Done");
    }

    public static async Task Main(string[] args)
    {
        Program program = new Program();

        Task task1 = program.DownloadDataAsync();
        Task task2 = program.DownloadDataAsync2();


        await Task.WhenAll(task1, task2);
        Console.WriteLine("Program Ends");
    }
}