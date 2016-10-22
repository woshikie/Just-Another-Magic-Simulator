
using System.Collections;

namespace Card
{
    public class BallistaCharger : Card
    {
        /*
        Whenever Ballista Charger attacks, it deals 1 damage to target creature or player.
Crew 3 (Tap any number of creatures you control with total power 3 or more: This Vehicle becomes an artifact creature until end of turn.)
        */
        private const string UniqueCardName = "Ballista Charger";
        public BallistaCharger() : base(UniqueCardName) { }

    }
}
