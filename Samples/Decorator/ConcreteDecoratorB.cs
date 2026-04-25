namespace Samples.Decorator;
public class ConcreteDecoratorB : Decorator
{
    static void AddedBehavior() => Console.WriteLine("Added behavior");
    public override void Operation()
    {
        base.Operation();
        AddedBehavior();
    }
}
