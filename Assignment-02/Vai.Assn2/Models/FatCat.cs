using System;

namespace Vai.Assn2.Models
{
    public class FatCat : ICat
    {
        public FatCat()
        {
            FatnessWidth = 500;
        }

        public void Meow()
        {
            Console.WriteLine("FAT MEOW");
        }

        public int FatnessWidth { get; set; }
    }
}
