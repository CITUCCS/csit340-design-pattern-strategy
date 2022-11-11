namespace Ducks
{
    public class RubberDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("SQUEEEK!");
        }
        public override void Fly()
        {
            Console.WriteLine("No flying behavior...");
        }
        public override void Display()
        {
            Console.WriteLine("Rubber Duck!");
        }
    }
}
