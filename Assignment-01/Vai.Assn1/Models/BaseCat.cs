using System;
using Vai.Assn1.Interfaces;

namespace Vai.Assn1.Models
{
    public abstract class BaseCat : ICat
    {
        public virtual void Meow()
        {
            throw new NotImplementedException("You have to implement meow");
        }

        public virtual string Name { get; set; }
    }
}
