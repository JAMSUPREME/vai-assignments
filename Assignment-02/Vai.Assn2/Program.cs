using System;
using Vai.Assn2.Factory;
using Vai.Assn2.Models;
using Vai.Assn2.Services;

namespace Vai.Assn2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Making a few cats and treating them as ICat
            // This is good for a demonstration, but in real life generally you won't do this
            ICat fatCat = new FatCat();
            ICat shortCat = new ShortCat();

            fatCat.Meow();
            shortCat.Meow();

            // Since we know we have a fat cat, we can use our fat cat printer
            FatCat castFatCat = fatCat as FatCat;
            FatCatPrinter.Print(castFatCat);

            // What happens if we cast our ShortCat as a FatCat?
            FatCat castShortCat = shortCat as FatCat;
            FatCatPrinter.Print(castShortCat);

            // What would happen if we didn't use the "as" keyword?
            // FatCatPrinter.Print((FatCat)shortCat);

            // What's the advantage of using "as" ?
            // We can do null checks
            //FatCat castShortCat2 = shortCat as FatCat;
            //if (castShortCat2 != null)
            //    FatCatPrinter.Print(castShortCat2);

            // The "is" keyword is similar to as, but only returns true/false
            if (shortCat is FatCat)
            {
                FatCatPrinter.Print((FatCat)shortCat);
            }

            Console.WriteLine("---");
            Console.WriteLine("--- Now using factory ---");
            Console.WriteLine("---");

            // More realistic example of getting cats
            ICat catFromFactory1 = CatFactory.GetCat();
            ICat catFromFactory2 = CatFactory.GetCat();

            catFromFactory1.Meow();
            catFromFactory2.Meow();

            // Assignment
            //
            // todo: Use both keywords "as" and "is" to safely call the FatCatPrinter.Print method
            //

        }
    }
}
