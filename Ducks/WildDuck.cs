using Ducks.Behaviors.Fly;
using Ducks.Behaviors.Quack;

namespace Ducks
{
    public class WildDuck : Duck
    {
        public WildDuck() : base(new NormalFlyBehavior(), new NormalQuackBehavior())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Wild Duck!");
        }
    }
}
