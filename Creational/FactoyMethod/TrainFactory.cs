using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Design_Pattern.Creational.FactoyMethod
{
    internal class TrainFactory : ToyFactory
    {
        public override IToy CreateToy() => new Train();
    }
}
