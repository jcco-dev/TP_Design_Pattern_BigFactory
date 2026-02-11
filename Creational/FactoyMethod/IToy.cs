using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TP_Design_Pattern.Creational.FactoyMethod
{
    internal interface IToy
    {
        string Name { get; }
        Decimal BasePrice { get; }
        string GetDescription();
        decimal GetPrice();
    }
}
