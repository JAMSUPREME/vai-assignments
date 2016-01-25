using System;
using Vai.Assn1.Interfaces;

namespace Vai.Assn1.Helper
{
    public static class CatNamePrinter
    {
        /// <summary>
        /// Prints cat names
        /// </summary>
        /// <param name="cats"></param>
        public static void PrintCatInfo(params ICat[] cats)
        {
            foreach (ICat cat in cats)
            {
                Console.WriteLine(cat.Name);
            }
        }
    }
}
