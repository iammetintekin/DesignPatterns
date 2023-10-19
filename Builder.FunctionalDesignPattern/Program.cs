
using Builder.FunctionalDesignPattern;

var person = new PersonBuilder().CallByName("Metin").Build();
Console.WriteLine(person.Name);