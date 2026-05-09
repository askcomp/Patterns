namespace Samples.Pipeline.Rules;

internal class AgeStep : IValidationStep
{
    public int Order => 30;
    public void Execute(ValidationContext context)
    {
        if (context.User.Age < 18)
            context.Fail("Регистрация только с 18 лет.");
    }
}
