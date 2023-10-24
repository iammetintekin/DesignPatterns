// See https://aka.ms/new-console-template for more information
using SOLID;

Console.WriteLine("-- Solid Prensipleri --");
//SingleResponsibility singleResponsibility = new SingleResponsibility();
//singleResponsibility.Run();

//OpenClosed openClosed = new OpenClosed();
//openClosed.Run2();   

//LiskovSubstitution liskovSubstitution = new LiskovSubstitution();
//liskovSubstitution.Run();

//DependencyInversion dependencyInversion = new DependencyInversion();
//dependencyInversion.Run();
Console.WriteLine(Solution(12, 6));
int Solution(int sayi1, int sayi2)
{
    int max = sayi1 * sayi2;
    int ekok = 0;
    /* 2 sayı eger aralarında asal ise ekoku
    çarpımlarıdır. Yanı 2 sayının ekoku maximum çarpımlarıdır.*/

    for (int i = max; i > 0; i--)
    {
        if (i % sayi1 == 0 && i % sayi2 == 0)
        {
            ekok = i;
        }
    } 
    return ekok;
}
