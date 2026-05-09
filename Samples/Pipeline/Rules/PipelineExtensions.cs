namespace Samples.Pipeline.Rules;

internal static class PipelineExtensions
{
    public static PipelineStep Then(this PipelineStep first, PipelineStep next)
    {
        return context =>
        {
            var result = first(context);
            if (!result.IsValid) return result;
            return next(result);
        };
    }
}
