using Samples.Decorator;

Func<string, string> core = MessageProcessors.WriteToConsole;
Func<string, string> decorated = MessageDecorators.Capitalize(core);
decorated = MessageDecorators.RedColor(decorated);
decorated = MessageDecorators.AddPrefix(decorated, "[LOG]");

decorated("Hello, World!");