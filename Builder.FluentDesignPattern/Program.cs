// See https://aka.ms/new-console-template for more information
using Builder.FluentDesignPattern;
using Builder.FluentDesignPattern.EasyMod;

Console.WriteLine("Fluent Builder");
var person = Person.New.Called("Metin").WorkAs("Engineer").InCompany("The Tekin Holding").Build();
Console.WriteLine(person);
Console.WriteLine("Fluent Builder Easy way");

Soldier soldier = new Soldier();
soldier.Moves.Run().TurnLeft().TurnRight().Shot();