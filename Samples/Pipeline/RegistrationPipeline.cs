namespace Samples.Pipeline;

internal class RegistrationPipeline
{
    private readonly List<IValidationStep> _steps = new();
    public void AddStep(IValidationStep step) => _steps.Add(step);

    public bool Process(User user)
    {
        var context = new ValidationContext(user);

        var sortedSteps = _steps.OrderBy(s => s.Order);

        foreach (var step in sortedSteps)
        {
            step.Execute(context);
            if (!context.IsValid)
            {
                System.Console.WriteLine($"Ошибка на этапе {step.GetType().Name}: {context.ErrorMessage}");
                return false;
            }
        }

        System.Console.WriteLine("Все проверки пройдены. Пользователь зарегистрирован!");
        return true;
    }
}