// gives abstract objects
public class TeaFactory : IHotDrinkFactory
{
    public IHotDring Prepare(int amount)
    {
        Console.WriteLine($"{amount} Tea");
        return new Tea();
    }
}
