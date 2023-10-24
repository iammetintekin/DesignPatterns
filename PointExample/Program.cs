// See initializing point.

using Factories.FactoryMethod;
using Factories.FactoryMethod.Seperated;
using PointExample;

var point = Point.Factory2.NewPolarPoint(1,Math.PI/2);
//var aaa = new Point(1, 2); // görüldüğü gibi constructor artık kullanılamaz
Console.WriteLine(point);

// async example

Foo result = await Foo.CreateAsync();
