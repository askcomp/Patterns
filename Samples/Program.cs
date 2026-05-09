using Samples.Pipeline;
using Samples.Pipeline.Rules;
System.Console.OutputEncoding = System.Text.Encoding.UTF8;

var user1 = new User
{
    Name = "Иван Иванов",
    Age = 25,
    Email = "admin@fa.ua",
    Password = "password",
};


var registrationService = new RegistrationService();
var res = registrationService.Register(user1);
Console.WriteLine(res);


var user2 = new User
{
    Name = "Алексей",
    Age = 17,
    Email = "test.com",
    Password = "123"
};

var pipeline = new RegistrationPipeline();
pipeline.AddStep(new NameStep());
pipeline.AddStep(new AgeStep());
pipeline.AddStep(new EmailStep());

pipeline.Process(user2);


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