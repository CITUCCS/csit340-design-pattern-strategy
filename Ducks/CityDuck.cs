using Ducks.Behaviors.Fly;
using Ducks.Behaviors.Quack;

namespace Ducks
{
    public class CityDuck : Duck
    {
        // We are now able to share Normal quacking behavior...
        public CityDuck() : base(new CityFlyBehavior(), new NormalQuackBehavior())
        {
        }

        public override void Display()
        {
            Console.WriteLine("City Duck!");
        }
    }
}
