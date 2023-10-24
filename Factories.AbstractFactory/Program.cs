// gives abstract objects
using static HotDrinkMachine;

Console.WriteLine("Hello, World!");

HotDrinkMachine machine = new HotDrinkMachine();
var drink = machine.MakeDrink(AvaibleDrink.Coffee, 1);
drink.Consume();
