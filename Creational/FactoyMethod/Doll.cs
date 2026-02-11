using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Design_Pattern.Creational.FactoyMethod
{
    internal class Doll : IToy
    {
        public string Name => "Doll";
        public decimal BasePrice => 18m;

        public string GetDescription() => "Poupée classique.";
        public decimal GetPrice() => BasePrice;
    }
}
