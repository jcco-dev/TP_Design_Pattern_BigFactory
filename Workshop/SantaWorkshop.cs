using System;
using System.Collections.Generic;
using System.Text;
using TP_Design_Pattern.Behavioral.Observer;
using TP_Design_Pattern.Creational.FactoyMethod;
using TP_Design_Pattern.Structural.Decorator;

namespace TP_Design_Pattern.Workshop
{
    internal class SantaWorkshop
    {
        private readonly WorkshopNotifier _notifier;

        public SantaWorkshop(WorkshopNotifier notifier) => _notifier = notifier;

        public IToy ProduceToy(
            ToyFactory factory,
            bool giftWrap,
            bool glitter,
            string? personalizedName)
        {
            // 1) Création (Factory Method)
            IToy toy = factory.CreateToy();
            _notifier.Notify(ProductionStep.Created, $"Jouet créé: {toy.Name}");

            // 2) Décoration (Decorator)
            if (!string.IsNullOrWhiteSpace(personalizedName))
                toy = new PersonalizedNameDecorator(toy, personalizedName);

            if (glitter)
                toy = new GlitterDecorator(toy);

            if (giftWrap)
                toy = new GiftWrapDecorator(toy);

            _notifier.Notify(ProductionStep.Decorated, $"Décorations ajoutées: {toy.GetDescription()}");

            // 3) Emballage / expédition (étapes)
            _notifier.Notify(ProductionStep.Packed, $"Emballage terminé. Prix final: {toy.GetPrice():0.00}€");
            _notifier.Notify(ProductionStep.Shipped, $"Expédié ! Bon Noël");

                return toy;
        }
    }

}
