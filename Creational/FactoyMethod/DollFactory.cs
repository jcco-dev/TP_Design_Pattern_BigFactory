using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Design_Pattern.Creational.FactoyMethod
{
    internal class DollFactory : ToyFactory
    {
        public override IToy CreateToy() => new Doll();
    }
}
