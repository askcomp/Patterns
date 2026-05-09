namespace Samples.Pipeline.Rules;

internal static class ValidationSteps
{
    public static PipelineStep NameStep = context =>
    {
        if (string.IsNullOrWhiteSpace(context.User.Name))
            context.Fail("Имя не может быть пустым.");
        return context;
    };

    public static PipelineStep AgeStep = context =>
    {
        if (context.User.Age < 18)
            context.Fail("Регистрация только с 18 лет.");
        return context;
    };

    public static PipelineStep EmailStep = context =>
    {
        if (!context.User.Email.Contains("@"))
            context.Fail("Некорректный Email.");
        return context;
    };
}

internal delegate ValidationContext PipelineStep(ValidationContext context);