namespace Samples.Decorator;

// Основной (конкретный) компонент
internal class ConsoleMessageWriter : IMessageWriter
{
    public void Write(string message) => Console.WriteLine(message);
}
