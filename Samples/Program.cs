
using Samples.Decorator;

IMessageWriter writer = new ConsoleMessageWriter();
IMessageWriter capitalizedWriter = new MessageCapitalizer(writer);
IMessageWriter redCapitalizedWriter = new RedConsoleMessageWriter(capitalizedWriter);

writer.Write("Hello, World!");
capitalizedWriter.Write("Hello, World!");
redCapitalizedWriter.Write("Hello, World!");
