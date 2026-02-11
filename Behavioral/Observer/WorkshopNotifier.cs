using System;
using System.Collections.Generic;
using System.Text;
using TP_Design_Pattern.Workshop;

namespace TP_Design_Pattern.Behavioral.Observer
{
    public class WorkshopNotifier
    {
        private readonly List<IElfObserver> _observers = new();

        public void Subscribe(IElfObserver observer)
        {
            if (!_observers.Contains(observer)) _observers.Add(observer);
        }

        public void Unsubscribe(IElfObserver observer) => _observers.Remove(observer);

        public void Notify(ProductionStep step, string message)
        {
            foreach (var obs in _observers) 
                obs.Update(step, message);
        }
    }
}
