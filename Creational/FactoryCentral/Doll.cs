using System;
using System.Collections.Generic;
using System.Text;
using TP_Design_Pattern.Creational.FactoryCentral;

namespace TP_Design_Pattern.Creational.FactoryCentral
{
    internal class Doll : IToy
    {
        public string Name => "Doll";
        public decimal BasePrice => 18m;

        public string GetDescription() => "Poupée classique.";
        public decimal GetPrice() => BasePrice;
    }
}
