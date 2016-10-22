
using System.Collections;

namespace Card
{
    public class Chandra,Pyrogenius : Card
    {
        /*
        +2: Chandra, Pyrogenius deals 2 damage to each opponent.
−3: Chandra, Pyrogenius deals 4 damage to target creature.
−10: Chandra, Pyrogenius deals 6 damage to target player and each creature he or she controls.
        */
        private const string UniqueCardName = "Chandra, Pyrogenius";
        public Chandra,Pyrogenius() : base(UniqueCardName) { }

    }
}
