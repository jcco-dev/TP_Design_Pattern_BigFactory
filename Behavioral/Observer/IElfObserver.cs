using System;
using System.Collections.Generic;
using System.Text;
using TP_Design_Pattern.Workshop;

namespace TP_Design_Pattern.Behavioral.Observer
{
    public interface IElfObserver
    {
        void Update(ProductionStep step, string message);
    }
}
