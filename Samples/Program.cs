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