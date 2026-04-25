namespace Samples.Decorator;
public abstract class Decorator : Component
{
    public Component? Component { protected get; set; }
    public override void Operation() => Component?.Operation();
}
