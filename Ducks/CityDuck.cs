namespace Ducks
{
    public class CityDuck : Duck
    {
        public override void Quack()
        {
            // Same behavior with WildDuck
            Console.WriteLine("Normal Quacking...");
        }
        public override void Fly()
        {
            Console.WriteLine("City Flying...");
        }
        public override void Display()
        {
            Console.WriteLine("City Duck!");
        }
    }
}
