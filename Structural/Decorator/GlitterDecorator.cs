using System;
using System.Collections.Generic;
using System.Text;
using TP_Design_Pattern.Creational.FactoyMethod;

namespace TP_Design_Pattern.Structural.Decorator
{
    internal class GlitterDecorator : ToyDecorator
    {
        public GlitterDecorator(IToy inner) : base(inner) { }

        public override string GetDescription()
        => $"{base.GetDescription()} + Paillettes";

        public override decimal GetPrice()
        => base.GetPrice() + 2m;
    }
}
