using System;
using ZadanieDomowe.Humans;
using ZadanieDomowe.Animals;
using ZadanieDomowe.Animals.Fishes;
using System.Collections.Generic;

namespace ZadanieDomowe
{
    class Program
    {
        static void Main(string[] args)
        {
            BeginChasingCircle();
            Console.ReadLine();
        }

        private static void BeginChasingCircle()
        {
            List<Animal> animals = new List<Animal> { new Fish(), new Animals.Birds.Ostrich(), new Animals.Mammals.Fox(), new Animals.Birds.Parrot() };
            foreach (var animal in animals)
            {
                StartChase(animal);
            }
        }

        private static void StartChase(ILivingCreature animal)
        {
            var pray = animal as Animal;
            Hunter hunter = new Hunter();
            hunter.Chase(pray);
        }
    }
}
