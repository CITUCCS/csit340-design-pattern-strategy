namespace Ducks.Behaviors.Quack
{
    internal class NormalQuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Normal Quacking...");
        }
    }
}