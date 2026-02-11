using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Design_Pattern.Creational.FactoryCentral
{
    internal interface IToy
    {
        string Name { get; }
        decimal BasePrice { get; }
        string GetDescription();
        decimal GetPrice();
    }
}
