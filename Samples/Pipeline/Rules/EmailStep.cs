namespace Samples.Pipeline.Rules;

internal class EmailStep : IValidationStep
{
    public int Order => 20;
    public void Execute(ValidationContext context)
    {
        if (!context.User.Email.Contains("@"))
            context.Fail("Некорректный Email.");
    }
}

