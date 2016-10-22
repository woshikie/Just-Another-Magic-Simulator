
using System.Collections;

namespace Card
{
    public class ChandraTorchofDefiance : Card
    {
        /*
        +1: Exile the top card of your library. You may cast that card. If you don't, Chandra, Torch of Defiance deals 2 damage to each opponent.
+1: Add {R}{R} to your mana pool.
−3: Chandra, Torch of Defiance deals 4 damage to target creature.
−7: You get an emblem with "Whenever you cast a spell, this emblem deals 5 damage to target creature or player."
        */
        private const string UniqueCardName = "Chandra, Torch of Defiance";
        public ChandraTorchofDefiance() : base(UniqueCardName) { }

    }
}
