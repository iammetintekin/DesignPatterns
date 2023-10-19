// See https://aka.ms/new-console-template for more information
using Builder.StepwiseDesignPattern;

Console.WriteLine("Hello, World!");

var car = CarBuilder.Create().BuildCarType(CarType.Sedan).BuildhWheelSize(4).Build();

