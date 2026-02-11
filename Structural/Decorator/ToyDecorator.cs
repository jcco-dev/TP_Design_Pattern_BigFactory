using System;
using System.Collections.Generic;
using System.Text;
using TP_Design_Pattern.Creational.FactoyMethod;

namespace TP_Design_Pattern.Structural.Decorator
{
    internal abstract class ToyDecorator : IToy
    {
        protected readonly IToy Inner;

        protected ToyDecorator(IToy inner) => Inner = inner; 

        public virtual string Name => Inner.Name;
        public virtual decimal BasePrice => Inner.BasePrice;

        public virtual string GetDescription() => Inner.GetDescription();
        public virtual decimal GetPrice() => Inner.GetPrice();
    }
}
