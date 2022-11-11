namespace Ducks.Behaviors.Fly
{
    internal class NormalFlyBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Normal Flying....");
        }
    }
}