using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Design_Pattern.Creational.FactoryCentral
{
    internal static class ToyFactory
    {
        public static IToy CreateToy(ToyType type)
        {
            return type switch
            {
                ToyType.TeddyBear => new TeddyBear(),
                ToyType.Doll => new Doll(),
                ToyType.Train => new Train(),
                _ => throw new ArgumentException("Type inconnu")
            };
        }
    }
}
