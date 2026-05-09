namespace Samples.Pipeline.Rules;

internal class NameStep : IValidationStep
{
    public int Order => 10;

    public void Execute(ValidationContext context)
    {
        if (string.IsNullOrWhiteSpace(context.User.Name))
            context.Fail("Имя не может быть пустым.");
    }
}

