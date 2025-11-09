namespace SolidPrinciplesPractice.SRP.LoggingService.After
{
    public class EventLogService
    {
        public static void Log(string message)
        {
            Console.WriteLine($"\nLog to Event Log: {message}");
        }
    }
}

