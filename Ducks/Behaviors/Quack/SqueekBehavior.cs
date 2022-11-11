namespace Ducks.Behaviors.Quack
{
    internal class SqueekBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("SQUEEK!");
        }
    }
}