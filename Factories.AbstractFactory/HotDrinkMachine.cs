// gives abstract objects
public partial class HotDrinkMachine
{
    private List<(AvaibleDrink,IHotDrinkFactory)> factories = new();
    public HotDrinkMachine()
    {
        foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
        {
            if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
            {
                //factories.Add((t.Name.Replace("Factory", string.Empty), (IHotDrinkFactory)Activator.CreateInstance(t)));
            }
        }
    }
    public IHotDring MakeDrink(AvaibleDrink drink, int amount)
    {
        //return factories[drink].Prepare(amount);
        return null;
    }
}
