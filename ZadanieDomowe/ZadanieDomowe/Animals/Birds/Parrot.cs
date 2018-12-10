using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDomowe.Animals.Birds
{
    class Parrot:Animal, IFly
    {
        public override void RunAway()
        {
            Console.WriteLine($"{NameOfAnimial()} has succesfully flown away!");
        }

        public override bool TryToRunAway()
        {
            Console.WriteLine($"{ NameOfAnimial() } is trying to fly away.");
            return IsSuccesfull();
        }
    }
}
