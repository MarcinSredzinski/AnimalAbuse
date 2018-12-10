using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ZadanieDomowe.Animals
{
    public abstract class Animal : IEscape, ILivingCreature
    {
        protected virtual bool IsSuccesfull()
        {
            return false;
        }
        public void Eat()
        {
        }

        public void Move()
        {
        }

        public string NameOfAnimial()
        {
            return GetType().Name.ToString();
        }

        public virtual void RunAway()
        {
            Console.WriteLine($"{NameOfAnimial()} has succesfully run away!");
        }

        public void Sleep()
        {
        }

        public virtual bool TryToRunAway()
        {
            Console.WriteLine($"{ NameOfAnimial() } is trying to run away.");
            return IsSuccesfull();
        }


    }
}
