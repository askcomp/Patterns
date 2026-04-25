namespace Samples.Decorator;
internal class RedConsoleMessageWriter(IMessageWriter messageWriter) : IMessageWriter
{
    private readonly IMessageWriter _messageWriter = messageWriter;

    public void Write(string message)
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        _messageWriter.Write(message);
        Console.ForegroundColor = color;
    }
}
