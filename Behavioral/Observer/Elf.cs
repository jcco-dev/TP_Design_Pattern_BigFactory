using System;
using System.Collections.Generic;
using System.Text;
using TP_Design_Pattern.Workshop;

namespace TP_Design_Pattern.Behavioral.Observer
{
    public class Elf : IElfObserver
    {
        public string Name { get; }
        public Elf(string name) => Name = name;

        public void Update(ProductionStep step, string message)
        {
            Console.WriteLine($"[Lutin {Name}] ({step} {message}");
        }
    }
}
