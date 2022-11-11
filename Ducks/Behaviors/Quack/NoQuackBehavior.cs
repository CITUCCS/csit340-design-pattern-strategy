using Ducks.Behaviors.Quack;

internal class NoQuackBehavior : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("No Quack Behavior....");
    }
}