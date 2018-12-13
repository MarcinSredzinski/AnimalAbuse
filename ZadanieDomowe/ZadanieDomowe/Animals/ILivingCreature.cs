using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDomowe.Animals
{
    public interface ILivingCreature : IEscape
    {
        void Sleep();   //przemyśl nazewnictwo - np force to sleep
        void Eat();     //feed lepsze
        void Move();    //może wylecieć
        bool TryToRunAway(); // w rzeczywistości zwierzę nie będzie miało wymuszonej ucieczki przez świat zewnętrzny
        //to zwierzę decyduje czy będzie uciekać. 
    }
}
