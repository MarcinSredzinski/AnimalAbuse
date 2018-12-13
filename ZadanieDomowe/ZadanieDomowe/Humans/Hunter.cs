using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using ZadanieDomowe.Animals;
namespace ZadanieDomowe.Humans
{
    class Hunter        //hunter nie powinien wymuszać ucieczki -to zwierzę stwierdza czy ucieka czy nie
    {                   //można to realizować poprzez event do którego podpinają się zwierzęta
        public void Chase(ILivingCreature pray)     //powinien informować tylko o tym że zaczynam gonić
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
