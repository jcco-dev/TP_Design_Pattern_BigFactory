using System;
using System.Collections.Generic;
using System.Text;
using TP_Design_Pattern.Creational.FactoryCentral;

namespace TP_Design_Pattern.Structural.Decorator
{
    internal class GiftWrapDecorator : ToyDecorator
    {
        public GiftWrapDecorator(IToy inner) : base(inner) { }

        public override string GetDescription()
        => $"{base.GetDescription()} + Emballage cadeau";

        public override decimal GetPrice()
        => base.GetPrice() + 3m;
    }
}
