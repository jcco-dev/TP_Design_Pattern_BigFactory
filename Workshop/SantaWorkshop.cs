using TP_Design_Pattern.Behavioral.Observer;
using TP_Design_Pattern.Creational.FactoryCentral;
using TP_Design_Pattern.Structural.Decorator;

namespace TP_Design_Pattern.Workshop
{
    public class SantaWorkshop
    {
        private readonly WorkshopNotifier _notifier;
        private readonly BigToyFactory _factory;

        public SantaWorkshop(WorkshopNotifier notifier, BigToyFactory factory)
        {
            _notifier = notifier;
            _factory = factory;
        }

        public IToy ProduceToy(
            ToyType type,
            bool giftWrap,
            bool glitter,
            string? personalizedName)
        {
            IToy toy = _factory.CreateToy(type);

            _notifier.Notify(ProductionStep.Created, $"Jouet créé: {toy.Name}");

            if (!string.IsNullOrWhiteSpace(personalizedName))
                toy = new PersonalizedNameDecorator(toy, personalizedName);

            if (glitter)
                toy = new GlitterDecorator(toy);

            if (giftWrap)
                toy = new GiftWrapDecorator(toy);

            _notifier.Notify(ProductionStep.Decorated, $"Décorations: {toy.GetDescription()}");
            _notifier.Notify(ProductionStep.Packed, $"Emballé. Prix: {toy.GetPrice():0.00}€");
            _notifier.Notify(ProductionStep.Shipped, "Expédié ");

            return toy;
        }
    }
}

