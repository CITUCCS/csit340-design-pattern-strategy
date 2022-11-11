using Ducks.Behaviors.Fly;
using Ducks.Behaviors.Quack;

namespace Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new NoFlyBehavior(), new SqueekBehavior())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Rubber Duck!");
        }
    }
}
