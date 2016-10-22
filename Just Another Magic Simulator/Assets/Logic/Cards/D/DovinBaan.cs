
using System.Collections;

namespace Card
{
    public class DovinBaan : Card
    {
        /*
        +1: Until your next turn, up to one target creature gets -3/-0 and its activated abilities can't be activated.
−1: You gain 2 life and draw a card.
−7: You get an emblem with "Your opponents can't untap more than two permanents during their untap steps."
        */
        private const string UniqueCardName = "Dovin Baan";
        public DovinBaan() : base(UniqueCardName) { }

    }
}
