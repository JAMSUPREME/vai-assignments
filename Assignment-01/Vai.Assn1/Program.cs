using System;
using Vai.Assn1.Helper;
using Vai.Assn1.Interfaces;
using Vai.Assn1.Models;

namespace Vai.Assn1
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate a cat
            ICat c = new UglyCat();

            // call Meow()
            c.Meow();

            // call IUglyCat implementation of meow
            // todo: your code here

            // make another cat that inherits BaseCat and pass it to this method
            // todo: your code here - (instantiate a new Cat type that you create)
            CatNamePrinter.PrintCatInfo(c);

            Console.Read();
        }
    }
}
