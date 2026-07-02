namespace Samples.Pipeline.Rules;

internal static class PipelineExtensions
{
    public static Func<ValidationContext, ValidationContext> Then(this Func<ValidationContext, ValidationContext> first, 
        Func<ValidationContext, ValidationContext> next)
    {
        return context =>
        {
            var result = first(context);
            if (!result.IsValid) return result;
            return next(result);
        };
    }
}
