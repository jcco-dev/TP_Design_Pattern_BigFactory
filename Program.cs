using System;
using TP_Design_Pattern.Behavioral.Observer;
using TP_Design_Pattern.Creational.FactoyMethod;
using TP_Design_Pattern.Workshop;

// Observer
var notifier = new WorkshopNotifier();
notifier.Subscribe(new Elf("Tic"));

var notifier1 = new WorkshopNotifier();
notifier1.Subscribe(new Elf("Tac"));

var notifier2 = new WorkshopNotifier();
notifier2.Subscribe(new Elf("Toc"));

var workshop = new SantaWorkshop(notifier);
var workshop1 = new SantaWorkshop(notifier1);
var workshop2 = new SantaWorkshop(notifier2);

// Factory Method : choisir le jouet
ToyFactory factory = new TeddyBearFactory();
ToyFactory factory1 = new DollFactory();
ToyFactory factory2 = new TrainFactory();


// Production avec décorations (Decorator)
var finalToy = workshop.ProduceToy(
    factory,
    giftWrap: true,
    glitter: true,
    personalizedName: "Yasmine"
);

var finalToy1 = workshop1.ProduceToy(
    factory1,
    giftWrap: true,
    glitter: true,
    personalizedName: "Yoyo"
);

var finalToy2 = workshop2.ProduceToy(
    factory2,
    giftWrap: true,
    glitter: true,
    personalizedName: "Joujou"
);

Console.WriteLine("\n--- Récap final ---");
Console.WriteLine($"Nom: {finalToy.Name}");
Console.WriteLine($"Description: {finalToy.GetDescription()}");
Console.WriteLine($"Prix: {finalToy.GetPrice():0.00}€");

Console.WriteLine("\n--- Récap final ---");
Console.WriteLine($"Nom: {finalToy1.Name}");
Console.WriteLine($"Description: {finalToy1.GetDescription()}");
Console.WriteLine($"Prix: {finalToy1.GetPrice():0.00}€");

Console.WriteLine("\n--- Récap final ---");
Console.WriteLine($"Nom: {finalToy2.Name}");
Console.WriteLine($"Description: {finalToy2.GetDescription()}");
Console.WriteLine($"Prix: {finalToy2.GetPrice():0.00}€");

Console.ReadKey();
