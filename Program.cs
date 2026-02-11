using System;
using TP_Design_Pattern.Behavioral.Observer;
using TP_Design_Pattern.Creational.FactoryCentral;
using TP_Design_Pattern.Workshop;

// 1) Notifier + lutins (Observer)
var notifier = new WorkshopNotifier();
notifier.Subscribe(new Elf("Tic"));
notifier.Subscribe(new Elf("Tac"));
notifier.Subscribe(new Elf("Toc"));

// 2) Atelier (Workshop)
var workshop = new SantaWorkshop(notifier);  

// 3) Produire différents jouets (FactoryCentral + Decorator)
var finalToy = workshop.ProduceToy(
    ToyType.TeddyBear,
    giftWrap: true,
    glitter: true,
    personalizedName: "Yasmine"
);

var finalToy1 = workshop.ProduceToy(
    ToyType.Doll,
    giftWrap: true,
    glitter: true,
    personalizedName: "Yoyo"
);

var finalToy2 = workshop.ProduceToy(
    ToyType.Train,
    giftWrap: true,
    glitter: true,
    personalizedName: "Joujou"
);

// 4) Affichage récap
Console.WriteLine("\n--- Récap final ---");
PrintToy(finalToy);
PrintToy(finalToy1);
PrintToy(finalToy2);

static void PrintToy(IToy toy)
{
    Console.WriteLine($"- {toy.Name}");
    Console.WriteLine($"  Desc: {toy.GetDescription()}");
    Console.WriteLine($"  Prix: {toy.GetPrice():0.00}€\n");
}

