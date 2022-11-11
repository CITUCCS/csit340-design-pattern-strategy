namespace Ducks
{
    public class WildDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Normal Quacking...");
        }
        public override void Fly()
        {
            Console.WriteLine("Normal Flying...");
        }
        public override void Display()
        {
            Console.WriteLine("Wild Duck!");
        }
    }
}
