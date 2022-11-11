using Ducks.Behaviors.Fly;
using Ducks.Behaviors.Quack;

namespace Ducks
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        protected Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
            _flyBehavior = flyBehavior;
        }

        public void Quack()
        {
            _quackBehavior.Quack();
        }
        public void Fly()
        {
            _flyBehavior.Fly();
        }
        public abstract void Display();
    }
}
