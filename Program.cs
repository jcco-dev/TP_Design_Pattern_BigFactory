using System;
using TP_Design_Pattern.Behavioral.Observer;
using TP_Design_Pattern.Creational.FactoryCentral;
using TP_Design_Pattern.Workshop;

var notifier = new WorkshopNotifier();
notifier.Subscribe(new Elf("Tic"));
notifier.Subscribe(new Elf("Tac"));
notifier.Subscribe(new Elf("Toc"));

var bigFactory = new BigToyFactory();

var workshop = new SantaWorkshop(notifier, bigFactory);

var toy1 = workshop.ProduceToy(ToyType.TeddyBear, giftWrap: true, glitter: true, personalizedName: "Yasmine");
var toy2 = workshop.ProduceToy(ToyType.Doll, giftWrap: true, glitter: true, personalizedName: "Yoyo");
var toy3 = workshop.ProduceToy(ToyType.Train, giftWrap: true, glitter: true, personalizedName: "Joujou");

Console.WriteLine("\n--- Récap final ---");
PrintToy(toy1);
PrintToy(toy2);
PrintToy(toy3);

static void PrintToy(IToy toy)
{
    Console.WriteLine($"- {toy.Name}");
    Console.WriteLine($"  Desc: {toy.GetDescription()}");
    Console.WriteLine($"  Prix: {toy.GetPrice():0.00}€\n");
}


