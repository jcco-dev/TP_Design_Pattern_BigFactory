using System;
using System.Collections.Generic;
using System.Text;
using TP_Design_Pattern.Creational.FactoryCentral;

namespace TP_Design_Pattern.Creational.FactoryCentral
{
    internal class TeddyBear : IToy
    {
        public string Name => "Teddy Bear";
        public decimal BasePrice => 15m;

        public string GetDescription() => "Péluche douce et câline.";
        public decimal GetPrice() => BasePrice;
    }
}
