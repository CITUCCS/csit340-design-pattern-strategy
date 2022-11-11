using Ducks;

DuckShowcase(new WildDuck());
DuckShowcase(new CityDuck());
DuckShowcase(new RubberDuck());
DuckShowcase(new ModelDuck());

void DuckShowcase(Duck duck)
{
    duck.Display();
    duck.Quack();
    duck.Fly();
    Console.WriteLine("----");
}

