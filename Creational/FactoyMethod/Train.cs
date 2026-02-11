using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Design_Pattern.Creational.FactoyMethod
{
    internal class Train : IToy
    {
        public string Name => "Wooden Train";
        public decimal BasePrice => 22m;

        public string GetDescription() => "Train en bois avec wagons.";
        public decimal GetPrice() => BasePrice;
    }
}
