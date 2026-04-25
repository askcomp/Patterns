namespace Samples.Decorator;
internal class MessageCapitalizer(IMessageWriter messageWriter) : IMessageWriter
{
    private readonly IMessageWriter _messageWriter = messageWriter;

    public void Write(string message)
    {
        _messageWriter.Write(message.ToUpperInvariant());
    }
}
