using System;
using System.Collections.Generic;
using System.Text;
using TP_Design_Pattern.Behavioral.Observer;
using TP_Design_Pattern.Creational.FactoryCentral;
using TP_Design_Pattern.Structural.Decorator;

namespace TP_Design_Pattern.Workshop
{
    internal class SantaWorkshop
    {
        private readonly WorkshopNotifier _notifier;

        public SantaWorkshop(WorkshopNotifier notifier) => _notifier = notifier;

        public IToy ProduceToy(
        ToyType type,
        bool giftWrap,
        bool glitter,
        string? personalizedName)
        
        {
            IToy toy = ToyFactory.CreateToy(type);

            _notifier.Notify(ProductionStep.Created, $"Jouet créé: {toy.Name}");

            if (!string.IsNullOrWhiteSpace(personalizedName))
                toy = new PersonalizedNameDecorator(toy, personalizedName);

            if (glitter)
                toy = new GlitterDecorator(toy);

            if (giftWrap)
                toy = new GiftWrapDecorator(toy);

            return toy;
        }
    }

}
