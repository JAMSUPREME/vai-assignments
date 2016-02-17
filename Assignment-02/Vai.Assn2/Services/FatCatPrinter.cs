using System;
using Vai.Assn2.Models;

namespace Vai.Assn2.Services
{
    public static class FatCatPrinter
    {
        public static void Print(FatCat c)
        {
            if (c == null)
            {
                Console.WriteLine("Fat cat was null?");
                return;
            }
            Console.WriteLine("Fat cat has a width of " + c.FatnessWidth);
        }
    }
}
