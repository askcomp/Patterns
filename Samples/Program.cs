using Samples.Pipeline;
using Samples.Pipeline.Rules;
System.Console.OutputEncoding = System.Text.Encoding.UTF8;

var user3 = new User
{
    Name = "Матвей",
    Age = 37,
    Email = "test.com,ua",
    Password = "456"
};

var validationPipeline = ValidationSteps.NameStep
    .Then(ValidationSteps.AgeStep)
    .Then(ValidationSteps.EmailStep);

var context = new ValidationContext(user3);
var finalContext = validationPipeline(context);
if (finalContext.IsValid)
{
    Console.WriteLine("✅ Все проверки пройдены. Пользователь зарегистрирован!");
}
else
{
    Console.WriteLine($"❌ Ошибка: {finalContext.ErrorMessage}");
}