using System;
using System.Collections.Generic;
using System.Text;
using TP_Design_Pattern.Creational.FactoyMethod;

namespace TP_Design_Pattern.Structural.Decorator
{
    internal class PersonalizedNameDecorator : ToyDecorator
    {
        private readonly string _ChildName;
        public PersonalizedNameDecorator(IToy inner, string childName) : base(inner)
            => _ChildName = childName;

        public override string GetDescription()
        => $"{base.GetDescription()} + Personnalisation : \"{_ChildName}\"";

        public override decimal GetPrice()
        => base.GetPrice() + 5m;
    }
}
