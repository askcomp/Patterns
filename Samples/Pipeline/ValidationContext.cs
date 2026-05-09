namespace Samples.Pipeline;

internal class ValidationContext(User user)
{
    public User User { get; set; } = user;
    public bool IsValid { get; private set; } = true;

    public string? ErrorMessage { get; private set; }

    public void Fail(string message)
    {
        IsValid = false;
        ErrorMessage = message;
    }
}