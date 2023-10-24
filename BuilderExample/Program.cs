// See https://aka.ms/new-console-template for more information
using BuilderExample;

var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
Console.WriteLine(cb);
//var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
//Console.WriteLine(cb);
//The expected output of the above code is:

//public class Person
//{
//    public string Name;
//    public int Age;
//}