namespace MyFirstApp;


class Program
{
    private static string password = "123456";

    private static bool CheckInput(string password)
    {
        Console.WriteLine("Enter your password \n");
        string userInput = Console.ReadLine()!.Trim();

        return userInput == password;
    }

    private static string CheckAge(int age)
    {
        return age switch
        {
            var a when a < 18 => "too young",
            var a when a > 65 => "too old",
            _ => "welcome back"
        };
    }

    static void Main(string[] args)
    {
        #region if else
            
        // if(CheckInput(password))
        // {
        //     Console.WriteLine("welcome back");
        // }
        // else 
        // {
        //     Console.WriteLine("Wrong");

        // }
        #endregion

        #region switch
        int age;
        Console.WriteLine("how old are u?");
        while(true)
        {
            string input = Console.ReadLine()!.Trim();

            if(int.TryParse(input, out age))
            {
                break;
            }
            Console.WriteLine("Please Enter Your age!!!!");
        };
        Console.WriteLine(CheckAge(age));
        #endregion
    
        
    }
}
