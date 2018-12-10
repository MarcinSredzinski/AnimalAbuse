using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ZadanieDomowe.Humans
{
    class Hunter
    {
        public void Chase(Animals.ILivingCreature pray)
        {     
            Console.WriteLine($"Hunter tries to catch the {(pray as Animals.Animal).NameOfAnimial()},");
            if (pray.TryToRunAway())
            {
                pray.RunAway();
                return;
            }
            else
            {
                Console.WriteLine($"Hunter caught the {(pray as Animals.Animal).NameOfAnimial()}");
            }
        }
    }
}
