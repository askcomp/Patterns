namespace Samples.Decorator;
public class ConcreteDecoratorA : Decorator
{
    string addedState = "Some state";
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine(addedState);   
    }
}
