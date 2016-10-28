
using System.Collections;

namespace Card
{
    public class SaheeliRai : Card
    {
        /*
        +1: Scry 1. Saheeli Rai deals 1 damage to each opponent.
−2: Create a token that's a copy of target artifact or creature you control, except it's an artifact in addition to its other types. That token gains haste. Exile it at the beginning of the next end step.
−7: Search your library for up to three artifact cards with different names, put them onto the battlefield, then shuffle your library.
        */
        private const string UniqueCardName = "Saheeli Rai";
        public SaheeliRai() : base(UniqueCardName) { }

    }
}
