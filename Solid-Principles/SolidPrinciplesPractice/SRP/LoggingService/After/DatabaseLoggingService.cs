namespace SolidPrinciplesPractice.SRP.LoggingService.After
{
    public class DatabaseLoggingService
    {
        public static void Log(string message)
        {
            Console.WriteLine($"\nLog to Database: {message}");
        }
    }
}

