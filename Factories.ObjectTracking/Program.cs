// See https://aka.ms/new-console-template for more information
using Factories.ObjectTracking;

Console.WriteLine("Hello, World!");

var factory = new TrackingThemeFactory();
factory.CreateTheme(true);
factory.CreateTheme(false);
Console.WriteLine(factory.Info);

var ReplecableThemeFactory = new ReplecableThemeFactory();
var magictheme = ReplecableThemeFactory.CreateTheme(true);
Console.WriteLine(magictheme.Value.BgColor);
ReplecableThemeFactory.ReplaceTheme(false);
Console.WriteLine(magictheme.Value.BgColor);

