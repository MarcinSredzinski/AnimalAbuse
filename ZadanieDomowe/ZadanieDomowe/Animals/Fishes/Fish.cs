using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDomowe.Animals.Fishes
{
    public class Fish : Animal, ISwimmer
    {
        public override void RunAway()
        {
            Console.WriteLine($"{NameOfAnimial()} has succesfully swum away!");
        }
        public override bool TryToRunAway()
        {
            Console.WriteLine($"{ NameOfAnimial() } is trying to swim away.");
            return IsSuccesfull();
        }
    }
}
