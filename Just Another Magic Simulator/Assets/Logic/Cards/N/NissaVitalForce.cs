
using System.Collections;

namespace Card
{
    public class NissaVitalForce : Card
    {
        /*
        +1: Untap target land you control. Until your next turn, it becomes a 5/5 Elemental creature with haste. It's still a land.
−3: Return target permanent card from your graveyard to your hand.
−6: You get an emblem with "Whenever a land enters the battlefield under your control, you may draw a card."
        */
        private const string UniqueCardName = "Nissa, Vital Force";
        public NissaVitalForce() : base(UniqueCardName) { }

    }
}
