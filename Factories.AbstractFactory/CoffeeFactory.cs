// gives abstract objects
public class CoffeeFactory : IHotDrinkFactory
{
    public IHotDring Prepare(int amount)
    {
        Console.WriteLine($"{amount} Coffee");
        return new Coffee();
    }
}
