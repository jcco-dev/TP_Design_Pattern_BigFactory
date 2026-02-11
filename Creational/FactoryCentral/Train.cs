using System;
using System.Collections.Generic;
using System.Text;
using TP_Design_Pattern.Creational.FactoryCentral;

namespace TP_Design_Pattern.Creational.FactoryCentral
{
    internal class Train : IToy
    {
        public string Name => "Wooden Train";
        public decimal BasePrice => 22m;

        public string GetDescription() => "Train en bois avec wagons.";
        public decimal GetPrice() => BasePrice;
    }
}
