public static class MessageDecorators
{
    public static Func<string, string> Capitalize(Func<string, string> processor)
    {
        return (message) =>
        {
            string modified = message.ToUpperInvariant();
            return processor(modified);
        };
    }

    public static Func<string, string> RedColor(Func<string, string> processor)
    {
        return (message) =>
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            var result = processor(message);
            Console.ForegroundColor = color;
            return result;
        };
    }

    public static Func<string, string> AddPrefix(Func<string, string> processor, string prefix)
    {
        return (message) => processor($"{prefix} {message}");
    }
}