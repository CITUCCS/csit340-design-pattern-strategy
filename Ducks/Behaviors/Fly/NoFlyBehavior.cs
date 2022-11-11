namespace Ducks.Behaviors.Fly
{
    internal class NoFlyBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("No Fly Behavior....");
        }
    }
}