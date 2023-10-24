// See https://aka.ms/new-console-template for more information
using Builder.FacetedBuilder;

Console.WriteLine("Hello, World!");

var PersonBuilder = new PersonBuilder();
Person created_person = PersonBuilder
    .Works().Position("Developer").Salary(25000).WorksIn("MTCOM")
    .Address().City("Aydın").PostalCode(09090).Address("Yeni mahalle");
Console.WriteLine(created_person);


