using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Design_Pattern.Creational.FactoryCentral
{
    public class BigToyFactory
    {
        readonly Dictionary<ToyType, Func<IToy>> _creators = new();

        public BigToyFactory()
        {
            // Enregistrements par défaut
            Register(ToyType.TeddyBear, () => new TeddyBear());
            Register(ToyType.Doll, () => new Doll());
            Register(ToyType.Train, () => new Train());
        }

        public void Register(ToyType type, Func<IToy> creator)
        {
            _creators[type] = creator ?? throw new ArgumentNullException(nameof(creator));
        }

        public IToy CreateToy(ToyType type)
        {
            if (_creators.TryGetValue(type, out var creator))
                return creator();

            throw new ArgumentException($"ToyType non supporté: {type}", nameof(type));
        }
    }
}
