using Ducks;
using Ducks.Behaviors.Fly;
using Ducks.Behaviors.Quack;

internal class ModelDuck : Duck
{
    public ModelDuck() : base(new NoFlyBehavior(), new NoQuackBehavior())
    {
    }

    public override void Display()
    {
        Console.WriteLine("Model Duck!");
    }
}