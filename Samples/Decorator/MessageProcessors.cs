namespace Samples.Decorator;
public static class MessageProcessors
{
    public static string WriteToConsole(string message)
    {
        Console.WriteLine($"Original: {message}");
        return message;
    }

    public static string WriteToFile(string message)
    {
        File.AppendAllText("log.txt", message + Environment.NewLine);
        return message;
    }

    public static string ReturnAsIs(string message) => message;
}