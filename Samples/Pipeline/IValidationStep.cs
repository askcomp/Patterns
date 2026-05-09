namespace Samples.Pipeline;

internal interface IValidationStep
{
    int Order { get; }
    void Execute(ValidationContext context);
}
