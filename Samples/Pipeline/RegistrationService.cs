namespace Samples.Pipeline;

internal class RegistrationService
{
    public bool Register(User user)
    {
        if (string.IsNullOrWhiteSpace(user.Name))
        {
            System.Console.WriteLine("Ошибка: Имя не может быть пустым.");
            return false;
        }

        if (user.Age < 18)
        {
            System.Console.WriteLine("Ошибка: Регистрация только с 18 лет.");
            return false;
        }

        if (!user.Email.Contains("@"))
        {
            System.Console.WriteLine("Ошибка: Некорректный Email.");
            return false;
        }

        if (user.Password.Length <= 6)
        {
            System.Console.WriteLine("Ошибка: Пароль слишком короткий.");
            return false;
        }

        System.Console.WriteLine("Пользователь успешно зарегистрирован!");
        return true;
    }
}
