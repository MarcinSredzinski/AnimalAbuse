using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDomowe.Animals
{
    public interface ILivingCreature : IEscape
    {
        void Sleep();
        void Eat();
        void Move();
        bool TryToRunAway();
    }
}
