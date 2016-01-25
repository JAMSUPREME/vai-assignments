using System;
using Vai.Assn1.Interfaces;

namespace Vai.Assn1.Models
{
    public class UglyCat : BaseCat, IUglyCat
    {
        public override void Meow()
        {
            throw new NotImplementedException("Do something different than BaseCat");
        }

        void IUglyCat.Meow()
        {
            Console.WriteLine("Ugly meow");
        }

        public override string Name
        {
            get { return "Ugly " + base.Name; }
            set { base.Name = value; }
        }
    }
}
