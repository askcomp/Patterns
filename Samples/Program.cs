
using Microsoft.Extensions.DependencyInjection;
using Samples.Decorator;

// Создаем коллекцию сервисов (DI-контейнер)
var services = new ServiceCollection();

// ШАГ 1: Регистрируем чистый базовый класс с ключом "base"
services.AddKeyedTransient<IMessageWriter, ConsoleMessageWriter>("base");

// ШАГ 2: Регистрируем MessageCapitalizer с ключом "capitalized".
// Внедряем в него сервис по ключу "base".
services.AddKeyedTransient<IMessageWriter, MessageCapitalizer>("capitalized", (sp, key) =>
{
    var baseWriter = sp.GetRequiredKeyedService<IMessageWriter>("base");
    return new MessageCapitalizer(baseWriter);
});

// ШАГ 3: Регистрируем RedConsoleMessageWriter как ОСНОВНОЙ (безключевой) сервис.
// Именно его DI отдаст по умолчанию. Внедряем в него сервис по ключу "capitalized".
services.AddTransient<IMessageWriter>(sp =>
{
    var capitalizedWriter = sp.GetRequiredKeyedService<IMessageWriter>("capitalized");
    return new RedConsoleMessageWriter(capitalizedWriter);
});

// Строим провайдер сервисов
var serviceProvider = services.BuildServiceProvider();

var writer = serviceProvider.GetRequiredService<IMessageWriter>();

writer.Write("hello from .net decorator!");
