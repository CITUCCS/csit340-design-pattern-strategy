using Ducks;

DuckShowcase(new WildDuck());
DuckShowcase(new CityDuck());
DuckShowcase(new RubberDuck());

void DuckShowcase(Duck duck)
{
    duck.Display();
    duck.Quack();
    duck.Fly();
    Console.WriteLine("----");
}

