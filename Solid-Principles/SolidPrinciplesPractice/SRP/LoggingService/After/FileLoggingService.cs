namespace SolidPrinciplesPractice.SRP.LoggingService.After
{
    public class FileLoggingService
    {
        public static void Log(string message)
        {
            Console.WriteLine($"\nLog to file: {message}");
        }
    }
}

